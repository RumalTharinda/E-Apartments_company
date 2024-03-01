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

namespace WindowsFormsApp1
{
    public partial class frm_login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=MSi;Initial Catalog=E-Apartments Login;Integrated Security=True");
        SqlDataAdapter da;
        SqlCommand cmd;

        public frm_login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                //IF the connection open by a hacker or someone close the connection for safty//
                con.Close();
            }

            con.Open();
            //MessageBox.Show("connected");// to show it coonected for testing perpose ....//

        }

        string log;

        private void btn_login_Click(object sender, EventArgs e)         //LOGIN button//
        {
            string userName = txt_userName.Text; //user name//
            string password = txt_password.Text; //pasword//

            if (userName == "")      // if user name is missing error massage //
            {
                lbl_errorName.Text = "Place enter User Name";
            }

            if (userName != "")    // delete user name is missing error massage//
            {
                lbl_errorName.Text = "";
            }

            if (password == "")    // if password is missing error massage //
            {
                lbl_errorPassword.Text = "Place enter Password";
            }

            if (password != "")   // delete password is missing error massage//
            {
                lbl_errorPassword.Text = "";
            }

            try
            {
                cmd = new SqlCommand("SELECT * FROM login WHERE userName = '" + txt_userName.Text + "' AND password ='" + txt_password.Text + "'", con);
                da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                int i = ds.Tables[0].Rows.Count;
                if(i == 1)
                {
                    
                    SqlDataReader dr = cmd.ExecuteReader();   // Adding user role athurization//
                    dr.Read();
                    if (dr[3].ToString() == "Admin")
                    {
                        ulog.type = "A";
                    }
                    else if (dr[3].ToString() == "User")
                    {
                        ulog.type = "U";
                    }
                    else if (dr[3].ToString() == "Clerk")
                    {
                        ulog.type = "C";
                    }

                   // log = "Welcome: " + txt_userName.Text;  // wellcome home page text//
                    log = txt_userName.Text;

                    this.Hide();
                    frm_dashboard frm1 = new frm_dashboard(log);
                    frm1.Show();
                    

                }

               

                
                else
                {
                    MessageBox.Show("invalid login details", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 
                }


            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                con.Close();
            }

           

        }

        

        private void btn_exit_Click(object sender, EventArgs e)           //EXIT button //
        {
            this.Close();
        }


    }
}
