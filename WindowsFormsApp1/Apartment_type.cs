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
    public partial class frm_ApartmentType : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=MSi;Initial Catalog=E-Apartments Login;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;

        int Id;

        public frm_ApartmentType()
        {
            InitializeComponent();
        }

        public void Clear() // Clear data methord//
        {
            txt_type.Text = "";
            txt_nBR.Text = "";
            txt_nCBR.Text = "";
            txt_nABR.Text = "";
            txt_nSR.Text = "";
            txt_nST .Text = "";
            


        }

        private void btn_new_Click(object sender, EventArgs e)  //Add New Apartment type//
        {
            con.Open();
            cmd = new SqlCommand("insert into ApartmentType values('" + txt_type.Text + "', '" + txt_nBR.Text + "', '" + txt_nCBR.Text + "', '" + txt_nABR.Text + "', '" + txt_nSR.Text + "', '" + txt_nST.Text + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data has been saved");
            con.Close();
            Clear();
            DisplayData();

        }
        public void DisplayData()   // Data grid for dependent table table//
        {
            con.Open();
            adpt = new SqlDataAdapter("select * from ApartmentType", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dgv_APType.DataSource = dt;

            con.Close();



        }

        private void btn_update_Click(object sender, EventArgs e) // UPdate apartment type//
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("update ApartmentType set Type = '" + txt_type.Text + "', No_of_Bedrooms = '" + txt_nBR.Text + "', No_of_CommonBathroom = '" + txt_nCBR.Text + "', No_of_AttachedBathroom = '" + txt_nABR.Text + "', No_of_Servantsroom = '" + txt_nSR.Text + "', No_of_Servantstoilet = '" + txt_nST.Text + "' where T_ID = '" + Id + "'", con);
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

        

        private void btn_delete_Click(object sender, EventArgs e)  //Delete apartment type//
        {
            con.Open();
            cmd = new SqlCommand("delete from ApartmentType where T_ID = '" + Id + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data has been deleted");
            con.Close();
            Clear();
            DisplayData();

        }

        private void dgv_APType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = Convert.ToInt32(dgv_APType.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_type.Text = dgv_APType.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_nBR.Text = dgv_APType.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_nCBR.Text = dgv_APType.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_nABR.Text = dgv_APType.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_nSR.Text = dgv_APType.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_nST.Text = dgv_APType.Rows[e.RowIndex].Cells[6].Value.ToString();
            
        }

        private void btn_showAll_Click(object sender, EventArgs e)
        {
            DisplayData();
        }
    }
}
