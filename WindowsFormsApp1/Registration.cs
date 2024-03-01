using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frm_registration : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=MSi;Initial Catalog=E-Apartments Login;Integrated Security=True");
        SqlCommand cmd;
        //SqlDataAdapter adpt;
        //DataTable dt;

        public frm_registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
           
        }
        public void Clear() // Clear data methord//
        {
            txt_name.Text = "";
            txt_Passsport_NIC.Text = "";
            txt_phone.Text = "";
            txt_address.Text = "";
            txt_ECName.Text = "";
            txt_ECPhone.Text = "";
            

        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("insert into customer values('" + txt_name.Text + "', '" + txt_Passsport_NIC.Text + "', '" + txt_phone.Text + "', '" + txt_address.Text + "', '" + txt_ECName.Text + "', '" + txt_ECPhone.Text + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data has been saved");
            con.Close();
            Clear();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
