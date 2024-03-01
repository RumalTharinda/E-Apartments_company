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
    public partial class frm_Info : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=MSi;Initial Catalog=E-Apartments Login;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;

        String Ava;
        public frm_Info()
        {
            InitializeComponent();
            Ava = "Available";
        }

        private void btn_availableApartment_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=MSi;Initial Catalog=E-Apartments Login;Integrated Security=True";
            con.Open();


            SqlDataAdapter sdp = new SqlDataAdapter("select * from Apartment where Apartment_State like '%" + Ava + "%'", con);


            DataTable dt = new DataTable();
            sdp.Fill(dt);

            dgv_info.DataSource = dt;



            con.Close();

        }

        private void btn_waitingList_Click(object sender, EventArgs e)
        {
            con.Open();
            adpt = new SqlDataAdapter("select * from WaitingList", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dgv_info.DataSource = dt;

            con.Close();

        }
    }
}
