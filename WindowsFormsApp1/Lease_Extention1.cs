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
    public partial class frm_Lease_Extention1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=MSi;Initial Catalog=E-Apartments Login;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;

        int Id;
        public frm_Lease_Extention1()
        {
            InitializeComponent();
        }

        private void frm_Lease_Extention1_Load(object sender, EventArgs e)
        {
            try                                                                  //Calling for customer table C_Name//
            {
                con.Open();
                DataSet ds = new DataSet();
                String C_Name = "select Chief_Occupant from Apartment";
                SqlDataAdapter sda = new SqlDataAdapter(C_Name, con);
                sda.Fill(ds);
                cmb_CName.DataSource = ds.Tables[0];
                cmb_CName.DisplayMember = ds.Tables[0].Columns[0].ToString();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in loading cmb" + ex);

            }
            finally
            {
                con.Close();
            }


            try                                                                  //Calling for customer table C_Name//
            {
                con.Open();
                DataSet ds = new DataSet();
                String A_ID = "select A_ID from Apartment";
                SqlDataAdapter sda = new SqlDataAdapter(A_ID, con);
                sda.Fill(ds);
                cmb_AID.DataSource = ds.Tables[0];
                cmb_AID.DisplayMember = ds.Tables[0].Columns[0].ToString();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in loading cmb" + ex);

            }
            finally
            {
                con.Close();
            }

        }

        public void Clear() // Clear data methord//
        {
            cmb_CName.Text = "";
            cmb_AID.Text = "";
            txt_period.Text = "";
            



        }
        public void DisplayData()   // Display Waiting list table//
        {
            con.Open();
            adpt = new SqlDataAdapter("select * from Lease_Extention", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dgv_LE.DataSource = dt;

            con.Close();

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("insert into Lease_Extention values('" + cmb_CName.Text + "', '" + cmb_AID.Text + "', '" + txt_period.Text + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data has been saved");
            con.Close();
            Clear();
            DisplayData();

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("delete from Lease_Extention where LE_ID = '" + Id + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data has been deleted");
            con.Close();
            Clear();
            DisplayData();

        }

        private void btn_showAll_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void dgv_LE_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = Convert.ToInt32(dgv_LE.Rows[e.RowIndex].Cells[0].Value.ToString());
            cmb_CName.Text = dgv_LE.Rows[e.RowIndex].Cells[1].Value.ToString();
            cmb_AID.Text = dgv_LE.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_period.Text = dgv_LE.Rows[e.RowIndex].Cells[3].Value.ToString();
            
        }
    }
}
