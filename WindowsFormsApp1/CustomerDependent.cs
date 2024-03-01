using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frm_CustomerDependent : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=MSi;Initial Catalog=E-Apartments Login;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;

        int DId;
        public frm_CustomerDependent()
        {
            InitializeComponent();
        }

        public void Clear() // Clear data methord//
        {
            cmb_cName.Text = "";
            txt_DName.Text = "";
            txt_DNIC.Text = "";
            txt_DAddress.Text = "";
            txt_DPhone.Text = "";
            txt_Relationship.Text = "";
            txt_DECDetails.Text = "";


        }

        private void btn_new_Click(object sender, EventArgs e)  // Add new dependents//
        {
            con.Open();
            cmd = new SqlCommand("insert into Dependent values('" + cmb_cName.Text + "', '" + txt_DName.Text + "', '" + txt_DNIC.Text + "', '" + txt_DAddress.Text + "', '" + txt_DPhone.Text + "', '" + txt_Relationship.Text + "', '" + txt_DECDetails.Text + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data has been saved");
            con.Close();
            Clear();
            DisplayData();
        }

        public void DisplayData()   // Display dependent table //
        {
            con.Open();
            adpt = new SqlDataAdapter("select * from Dependent", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dgv_dependent.DataSource = dt;

            con.Close();



        }


        private void btn_update_Click(object sender, EventArgs e)  // Upadate dependent//
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("update Dependent set C_Name = '" + cmb_cName.Text + "', DependentName = '" + txt_DName.Text + "', DependentNIC = '" + txt_DNIC.Text + "', DependentAddress = '" + txt_DAddress.Text + "', DependentPhone = '" + txt_DPhone.Text + "', Relationship = '" + txt_Relationship.Text + "', D_EC_Details = '" + txt_DECDetails.Text + "' where D_ID = '" + DId + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data has been updated");

                con.Close();
                Clear();
                DisplayData();

                


            }
            catch (Exception)
            {

            }
        }

        private void btn_delete_Click(object sender, EventArgs e)  //Delete dependent //
        {
            con.Open();
            cmd = new SqlCommand("delete from Dependent where D_ID = '" + DId + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data has been deleted");
            con.Close();
            Clear();
            DisplayData();

        }

        private void btn_exit_Click(object sender, EventArgs e) //Exit btn//
        {
            this.Hide();

        }

        private void dgv_dependent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)   //grid select option//
        {
            DId = Convert.ToInt32(dgv_dependent.Rows[e.RowIndex].Cells[0].Value.ToString());
            cmb_cName.Text = dgv_dependent.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_DName.Text = dgv_dependent.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_DNIC.Text = dgv_dependent.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_DAddress.Text = dgv_dependent.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_DPhone.Text = dgv_dependent.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_Relationship.Text = dgv_dependent.Rows[e.RowIndex].Cells[6].Value.ToString();
            txt_DECDetails.Text = dgv_dependent.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void btn_all_Click(object sender, EventArgs e)   // Display all data//
        {
            DisplayData();
        }

        private void btn_search_Click(object sender, EventArgs e)  // Search bar//
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=MSi;Initial Catalog=E-Apartments Login;Integrated Security=True";
            con.Open();


            SqlDataAdapter sdp = new SqlDataAdapter("select * from Dependent where C_Name like '%" + txt_search.Text + "%'", con);


            DataTable dt = new DataTable();
            sdp.Fill(dt);

            dgv_dependent.DataSource = dt;



            con.Close();
        }

        private void frm_CustomerDependent_Load(object sender, EventArgs e)
        {
            try                                                                  //Calling for customer table C_Name//
            {
                con.Open();
                DataSet ds = new DataSet();
                String C_Name = "select C_Name from customer";
                SqlDataAdapter sda = new SqlDataAdapter(C_Name, con);
                sda.Fill(ds);
                cmb_cName.DataSource = ds.Tables[0];
                cmb_cName.DisplayMember = ds.Tables[0].Columns[0].ToString();
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error in loading cmb" +ex);

            }
            finally
            {
                con.Close();
            }

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
