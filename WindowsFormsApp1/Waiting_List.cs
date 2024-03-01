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
    public partial class frm_waitingList : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=MSi;Initial Catalog=E-Apartments Login;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;

        int Id;  

        public frm_waitingList()
        {
            InitializeComponent();
        }

        private void btn_new_Click(object sender, EventArgs e)  // Add new Customer to waiting list//
        {
            con.Open();
            cmd = new SqlCommand("insert into WaitingList values('" + txt_CName.Text + "', '" + cmb_AType.Text + "', '" + txt_details.Text + "', '" + txt_phone.Text + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data has been saved");
            con.Close();
            Clear();
            DisplayData();

        }

        private void Waiting_List_Load(object sender, EventArgs e)
        {
            try                                                                  //Calling for apartment types //
            {
                con.Open();
                DataSet ds = new DataSet();
                String Type = "select Type from ApartmentType";
                SqlDataAdapter sda = new SqlDataAdapter(Type, con);
                sda.Fill(ds);
                cmb_AType.DataSource = ds.Tables[0];
                cmb_AType.DisplayMember = ds.Tables[0].Columns[0].ToString();
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
            txt_CName.Text = "";
            cmb_AType.Text = "";
            txt_details.Text = "";
            txt_phone.Text = "";
            


        }
        public void DisplayData()   // Display Waiting list table//
        {
            con.Open();
            adpt = new SqlDataAdapter("select * from WaitingList", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dgv_WL.DataSource = dt;

            con.Close();

        }

        private void btn_update_Click(object sender, EventArgs e) // Update waiting list//
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("update WaitingList set CustomerName = '" + txt_CName.Text + "', ApartmentType = '" + cmb_AType.Text + "', Detail = '" + txt_details.Text + "', Phone = '" + txt_phone.Text + "' where WL_ID = '" + Id + "'", con);
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

        private void dgv_WL_CellContentClick(object sender, DataGridViewCellEventArgs e)   // grid click //
        {
            Id = Convert.ToInt32(dgv_WL.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_CName.Text = dgv_WL.Rows[e.RowIndex].Cells[1].Value.ToString();
            cmb_AType.Text = dgv_WL.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_details.Text = dgv_WL.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_phone.Text = dgv_WL.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btn_delete_Click(object sender, EventArgs e)      //Delete from waiting list //
        {
            con.Open();
            cmd = new SqlCommand("delete from WaitingList where WL_ID = '" + Id + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data has been deleted");
            con.Close();
            Clear();
            DisplayData();
        }

        private void btn_exit_Click(object sender, EventArgs e)  //Exit btn//
        {
            this.Hide();
        }

        private void btn_SAll_Click(object sender, EventArgs e)    // show the waiting list table//
        {
            DisplayData();
        }

        private void btn_search_Click(object sender, EventArgs e)          // Search for waiting list name //
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=MSi;Initial Catalog=E-Apartments Login;Integrated Security=True";
            con.Open();


            SqlDataAdapter sdp = new SqlDataAdapter("select * from WaitingList where CustomerName like '%" + txt_search.Text + "%'", con);


            DataTable dt = new DataTable();
            sdp.Fill(dt);

            dgv_WL.DataSource = dt;



            con.Close();
        }
    }
}
