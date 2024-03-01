using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frm_Payment : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=MSi;Initial Catalog=E-Apartments Login;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;

        int DId;


        public frm_Payment()
        {
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            try                                                                  //Calling for customer table C_Name//
            {
                con.Open();
                DataSet ds = new DataSet();
                String C_Name = "select C_Name from customer";
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

        }

        public void DisplayData()   // Display payment table //
        {
            con.Open();
            adpt = new SqlDataAdapter("select * from Payment", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dgv_Pay.DataSource = dt;

            con.Close();

        }

        public void Clear() // Clear data methord//
        {
            cmb_CName.Text = "";
            cmb_PaymentType.Text = "";
            dtp_pay.Text = "";
            txt_amount.Text = "";
            

        }

        private void btn_new_Click(object sender, EventArgs e)    // Add new payment //
        {
            con.Open();
            cmd = new SqlCommand("insert into Payment values('" + cmb_CName.Text + "', '" + cmb_PaymentType.Text + "', '" + dtp_pay.Text + "', '" + txt_amount.Text + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data has been saved");
            con.Close();
            Clear();
            DisplayData();
        }

        private void btn_update_Click(object sender, EventArgs e)  // Update payment //
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("update Payment set C_Name = '" + cmb_CName.Text + "', P_Type = '" + cmb_PaymentType.Text + "', P_DayTime = '" + dtp_pay.Text + "', Amount = '" + txt_amount.Text + "' where P_ID = '" + DId + "'", con);
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

        private void dgv_Pay_CellContentClick(object sender, DataGridViewCellEventArgs e) // Grid click //
        {
            DId = Convert.ToInt32(dgv_Pay.Rows[e.RowIndex].Cells[0].Value.ToString());
            cmb_CName.Text = dgv_Pay.Rows[e.RowIndex].Cells[1].Value.ToString();
            cmb_PaymentType.Text = dgv_Pay.Rows[e.RowIndex].Cells[2].Value.ToString();
           // dtp_pay.Text = dgv_Pay.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_amount.Text = dgv_Pay.Rows[e.RowIndex].Cells[4].Value.ToString();
            
        }

        private void btn_delete_Click(object sender, EventArgs e)   // delete payment  //
        {
            con.Open();
            cmd = new SqlCommand("delete from Payment where P_ID = '" + DId + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data has been deleted");
            con.Close();
            Clear();
            DisplayData();
        }

        private void btn_Exit_Click(object sender, EventArgs e)   // Exit//
        {
            this.Hide();
        }

        private void btn_showAll_Click(object sender, EventArgs e)     // Display all payments//
        {
            DisplayData();
        }

        private void btn_search_Click(object sender, EventArgs e)       // search btn//
        {
            SqlConnection con = new SqlConnection();
           con.ConnectionString = "Data Source=MSi;Initial Catalog=E-Apartments Login;Integrated Security=True";
            con.Open();


            SqlDataAdapter sdp = new SqlDataAdapter("select * from Payment where C_Name like '%" + txt_search.Text + "%'", con);


            DataTable dt = new DataTable();
            sdp.Fill(dt);

            dgv_Pay.DataSource = dt;



            con.Close();
        }
    }
}
