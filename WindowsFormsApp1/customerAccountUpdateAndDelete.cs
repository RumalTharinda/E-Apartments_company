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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class frm_customerAccountUpdateAndDelete : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=MSi;Initial Catalog=E-Apartments Login;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;

        int Id;
        String dName;
        public frm_customerAccountUpdateAndDelete(int id, String name, string NIC, string phone, string address, string ecname, string ecphone)  // getting data //
        {
            InitializeComponent();

            txt_name.Text = name;          
            txt_Passsport_NIC.Text = NIC;
            txt_phone.Text = phone;
            txt_address.Text = address;
            txt_ECName.Text = ecname;
            txt_ECPhone.Text = ecphone;

            Id = id;
            dName = name;



        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            con.Open();
            cmd = new SqlCommand("delete from customer where C_Name = '" + dName + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data has been deleted");
            con.Close();
            this.Hide();

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
          
            try
            {
                con.Open();
                cmd = new SqlCommand("update customer set C_Name = '" + txt_name.Text + "', C_Passport_NIC = '" + txt_Passsport_NIC.Text + "', C_Phone = '" + txt_phone.Text + "', C_Address = '" + txt_address.Text + "', C_EC_Name = '" + txt_ECName.Text + "', C_EC_Phone = '" + txt_ECPhone.Text + "' where C_ID = '" + Id + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data has been updated");

                con.Close();

                this.Hide();


            }
            catch (Exception)
            {

            }
            /*
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update customer set '" + txt_name.Text + "'='" + txt_Passsport_NIC.Text + "'='" + txt_phone.Text + "'='" + txt_address.Text + "'='" + txt_ECName.Text + "'='" + txt_ECPhone.Text + "' where C_ID='" + Id + "'";
            cmd.ExecuteReader();
            con.Close();
          

           
            */
        }
    }
}
