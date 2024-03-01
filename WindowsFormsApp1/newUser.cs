using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp1
{
    public partial class frm_manageUserAccount : Form
    {
        

        SqlConnection con = new SqlConnection(@"Data Source=MSi;Initial Catalog=E-Apartments Login;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        int UserId;   // grid bouble click //
        string logNameMUA; // log as a who //

        public frm_manageUserAccount(string logName)
        {
            InitializeComponent();
            DisplayData();
            logNameMUA = logName;
        }
        
        private void btn_save_Click(object sender, EventArgs e)   //Button Save//
        {
            con.Open();
            cmd = new SqlCommand("insert into login values('"+txt_userName.Text+"', '"+txt_password.Text+"', '"+ cmb_role.Text + "')",con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data has been saved");
            con.Close();
            DisplayData();
            Clear();

        }

        public void DisplayData()   // Data grid for LogIn table//
        {
            con.Open();
            adpt = new SqlDataAdapter("select * from login", con);
            dt = new DataTable();
            adpt.Fill(dt); 
            dgv_login.DataSource = dt;
            con.Close();

        }

        public void Clear() // Clear data methord//
        {
            txt_userName.Text = "";
            txt_password.Text = "";
            cmb_role.Text = "";
        }

        private void btn_clear_Click(object sender, EventArgs e)  //Clear button//
        {

         Clear();
        }

       

        private void dgv_login_CellDoubleClick(object sender, DataGridViewCellEventArgs e)    //Double click grid select//
        {
            UserId = Convert.ToInt32(dgv_login.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_userName.Text = dgv_login.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_password.Text = dgv_login.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmb_role.Text = dgv_login.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)  // Update button //
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("update login set userName = '" + txt_userName.Text + "', password = '" + txt_password.Text + "', role = '" + cmb_role.Text + "' where id = '" + UserId + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data has been updated");

                con.Close();
                DisplayData();

            }
            catch (Exception)
            {
                
            }

          
        }

        private void btn_delete_Click(object sender, EventArgs e)  // Delete button // 
        {
            con.Open();
            cmd = new SqlCommand("delete from login where id = '" + UserId + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data has been deleted");
            con.Close();
            DisplayData();

        }
        
        

        private void btn_home_Click(object sender, EventArgs e)  // Back button to home//
        {
             

            frm_dashboard frm2 = new frm_dashboard(logNameMUA);
            frm2.Show();
            this.Hide();


           
        }
    }
}
