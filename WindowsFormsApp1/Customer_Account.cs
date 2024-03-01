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
    public partial class frm_CustomerAccount : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=MSi;Initial Catalog=E-Apartments Login;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;

        int customerId;  // dgv clik //
        string logNameCA;  // log as who//

        public frm_CustomerAccount(string logName)
        {
            InitializeComponent();
            logNameCA = logName;
        }

        public void DisplayData()   // Data grid for customer table//
        {
            con.Open();
            adpt = new SqlDataAdapter("select * from customer", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dvg_customerAccount.DataSource = dt;
                
            con.Close();

           

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            frm_registration r1 = new frm_registration();
            r1.Show();

            DisplayData();

           
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)         // delete button//
        {
            con.Open();
            cmd = new SqlCommand("delete from customer where C_ID = '" + customerId + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data has been deleted");
            con.Close();
            DisplayData();
        }

        private void btn_home_Click(object sender, EventArgs e)  // Back button to home//
        {
            frm_dashboard frm2 = new frm_dashboard(logNameCA);
            frm2.Show();
            this.Hide();


        }

        private void btnShowAll_Click(object sender, EventArgs e)  // show all btn//
        {
            DisplayData();
        }

        

        private void dgv_customerAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            customerId = Convert.ToInt32(dvg_customerAccount.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void dvg_customerAccount_CellDoubleClick(object sender, DataGridViewCellEventArgs e)  // to UPdate & Delete Customer Account//
        {

             customerId = Convert.ToInt32(dvg_customerAccount.Rows[e.RowIndex].Cells[0].Value.ToString());
             String name = dvg_customerAccount.Rows[e.RowIndex].Cells[1].Value.ToString();
             String NIC = dvg_customerAccount.Rows[e.RowIndex].Cells[2].Value.ToString();
             String phone = dvg_customerAccount.Rows[e.RowIndex].Cells[3].Value.ToString();
            String address = dvg_customerAccount.Rows[e.RowIndex].Cells[4].Value.ToString();
            String ECname = dvg_customerAccount.Rows[e.RowIndex].Cells[5].Value.ToString();
            String ECphone = dvg_customerAccount.Rows[e.RowIndex].Cells[6].Value.ToString();

            frm_customerAccountUpdateAndDelete UD = new frm_customerAccountUpdateAndDelete(customerId,name, NIC, phone, address, ECname, ECphone );
            UD.ShowDialog();

            DisplayData();
        }

        private void btnFind_Click(object sender, EventArgs e)  //Search bar//
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=MSi;Initial Catalog=E-Apartments Login;Integrated Security=True";
            con.Open();

           
            SqlDataAdapter sdp = new SqlDataAdapter("select * from customer where C_Name like '%" + txtSearch.Text+"%'",con);


            DataTable dt = new DataTable();
            sdp.Fill(dt);

            dvg_customerAccount.DataSource = dt;



            con.Close();
        }

        private void btn_dependents_Click(object sender, EventArgs e)
        {
            frm_CustomerDependent d1 = new frm_CustomerDependent();
            d1.Show();
        }
    }
}
