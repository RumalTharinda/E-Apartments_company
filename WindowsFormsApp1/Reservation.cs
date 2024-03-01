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
    public partial class frm_reservation : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=MSi;Initial Catalog=E-Apartments Login;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        String Ava;
        int AId;
        public frm_reservation()
        {
            InitializeComponent();
            Ava = "Available";
        }

        private void btn_AA_Click(object sender, EventArgs e)                      // Show all Available Apartment //
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=MSi;Initial Catalog=E-Apartments Login;Integrated Security=True";
            con.Open();


            SqlDataAdapter sdp = new SqlDataAdapter("select * from Apartment where Apartment_State like '%" + Ava + "%'", con);


            DataTable dt = new DataTable();
            sdp.Fill(dt);

            dgv_reservation.DataSource = dt;



            con.Close();
        }

        private void dgv_reservation_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AId = Convert.ToInt32(dgv_reservation.Rows[e.RowIndex].Cells[0].Value.ToString());
            cmb_Chief_Occupant.Text = dgv_reservation.Rows[e.RowIndex].Cells[8].Value.ToString();
            cmb_Apartment_State.Text = dgv_reservation.Rows[e.RowIndex].Cells[7].Value.ToString();
            
        }

        private void frm_reservation_Load(object sender, EventArgs e)
        {
            try                                                                  //Calling for customer table C_Name//
            {
                con.Open();
                DataSet ds = new DataSet();
                String C_Name = "select C_Name from customer";
                SqlDataAdapter sda = new SqlDataAdapter(C_Name, con);
                sda.Fill(ds);
                cmb_Chief_Occupant.DataSource = ds.Tables[0];
                cmb_Chief_Occupant.DisplayMember = ds.Tables[0].Columns[0].ToString();
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

        private void btn_reserve_Click(object sender, EventArgs e)   // Reserving Apartments for customers//
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("update Apartment set  Apartment_State = '" + cmb_Apartment_State.Text + "', Chief_Occupant = '" + cmb_Chief_Occupant.Text + "' where ID = '" + AId + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data has been updated");

                con.Close();
               // Clear();
               // DisplayData();

            }
            catch (Exception)
            {

            }
        }

        private void btn_WL_Click(object sender, EventArgs e) //Load Waiting List page
        {
            frm_waitingList W = new frm_waitingList();
            W.Show();
            this.Hide();
        }
    }
}
