using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    

    public partial class frm_apartment : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=MSi;Initial Catalog=E-Apartments Login;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;

        int iD;

        public frm_apartment()
        {
            InitializeComponent();
        }

        public void Clear() // Clear data methord//
        {
            txt_AID.Text = "";
            txt_BID.Text = "";
            txt_BAID.Text = "";
            cmb_AT.Text = "";
            txt_address.Text = "";
            txt_phone.Text = "";
            cmb_AS.Text = "";
            cmb_COP.Text = "";
            txt_TP.Text = "";
            cmb_MP.Text = "";
            cmb_APS.Text = "";


        }

        private void btn_new_Click(object sender, EventArgs e) // add new apartment//
        {

            try
            {
                con.Open();
                cmd = new SqlCommand("insert into Apartment values('" + txt_AID.Text + "', '" + txt_BID.Text + "', '" + txt_BAID.Text + "', '" + cmb_AT.Text + "', '" + txt_address.Text + "', '" + txt_phone.Text + "', '" + cmb_AS.Text + "', '" + cmb_COP.Text + "', '" + txt_TP.Text + "', '" + cmb_MP.Text + "', '" + cmb_APS.Text + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data has been saved");
                con.Close();
                Clear();
                DisplayData();



            }
            catch (Exception)
            {

            }
            /*
            con.Open();
            cmd = new SqlCommand("insert into Apartment values('" + txt_AID.Text + "', '" + txt_BID.Text + "', '" + txt_BAID.Text + "', '" + cmb_AT.Text + "', '" + txt_address.Text + "', '" + txt_phone.Text + "', '" + cmb_AS.Text + "', '" + cmb_COP.Text + "', '" + txt_TP.Text + "', '" + cmb_MP.Text + "', '" + cmb_APS.Text + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data has been saved");
            con.Close();
            Clear();
            DisplayData();
            */
        }

        public void DisplayData()   // Data grid for dependent table table//
        {
            con.Open();
            adpt = new SqlDataAdapter("select * from Apartment", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dgv_AP.DataSource = dt;
            
            con.Close();

        }

        private void dgv_AP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            iD = Convert.ToInt32(dgv_AP.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_AID.Text = dgv_AP.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_BID.Text = dgv_AP.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_BAID.Text = dgv_AP.Rows[e.RowIndex].Cells[3].Value.ToString();
            cmb_AT.Text = dgv_AP.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_address.Text = dgv_AP.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_phone.Text = dgv_AP.Rows[e.RowIndex].Cells[6].Value.ToString();
            cmb_AS.Text = dgv_AP.Rows[e.RowIndex].Cells[7].Value.ToString();
            cmb_COP.Text = dgv_AP.Rows[e.RowIndex].Cells[8].Value.ToString();
            txt_TP.Text = dgv_AP.Rows[e.RowIndex].Cells[9].Value.ToString();
            cmb_MP.Text = dgv_AP.Rows[e.RowIndex].Cells[10].Value.ToString();
            cmb_APS.Text = dgv_AP.Rows[e.RowIndex].Cells[11].Value.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)  // upadate btn//
        {
            
            try
            {
                con.Open();
                cmd = new SqlCommand("update Apartment set A_ID = '" + txt_AID.Text + "', Building_ID = '" + txt_BID.Text + "', BuildingApartment_ID = '" + txt_BAID.Text + "', Apartment_type = '" + cmb_AT.Text + "', Adress = '" + txt_address.Text + "', Phone = '" + txt_phone.Text + "', Apartment_State = '" + cmb_AS.Text + "', Chief_Occupant = '" + cmb_COP.Text + "', Time_Period = '" + txt_TP.Text + "', Max_People = '" + cmb_MP.Text + "', Additional_parcking_Space = '" + cmb_APS.Text + "' where ID = '" + iD + "'", con);
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

        private void btn_delete_Click(object sender, EventArgs e)   //delete btn//
        {
            con.Open();
            cmd = new SqlCommand("delete from Apartment where ID = '" + iD + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data has been deleted");
            con.Close();
            Clear();
            DisplayData();
        }

        private void btn_exit_Click(object sender, EventArgs e)  //Exit//
        {
            this.Hide();
        }

        private void btn_showAll_Click(object sender, EventArgs e) /// Show all Apartment//
        {
            DisplayData();
        }

        private void btn_search_Click(object sender, EventArgs e)  // search bar//
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=MSi;Initial Catalog=E-Apartments Login;Integrated Security=True";
            con.Open();

            
            SqlDataAdapter sdp = new SqlDataAdapter("select * from Apartment where A_ID like '%" + txt_search.Text + "%'", con);


            DataTable dt = new DataTable();
            sdp.Fill(dt);

            dgv_AP.DataSource = dt;



            con.Close();
        }

        private void frm_apartment_Load(object sender, EventArgs e)
        {
            try                                                                  //Calling for apartment type table type//
            {
                con.Open();
                DataSet ds = new DataSet();
                String Type = "select Type from ApartmentType";
                SqlDataAdapter sda = new SqlDataAdapter(Type, con);
                sda.Fill(ds);
                cmb_AT.DataSource = ds.Tables[0];
                cmb_AT.DisplayMember = ds.Tables[0].Columns[0].ToString();
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

            try                                                                  //Calling for customer table C_Name//
            {
                con.Open();
                DataSet ds = new DataSet();
                String C_Name = "select C_Name from customer";
                SqlDataAdapter sda = new SqlDataAdapter(C_Name, con);
                sda.Fill(ds);
                cmb_COP.DataSource = ds.Tables[0];
                cmb_COP.DisplayMember = ds.Tables[0].Columns[0].ToString();
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

       
    }
}
