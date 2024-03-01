using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frm_dashboard : Form
    {
        string logName; // log as who //
        public frm_dashboard(string log)
        {
            InitializeComponent();
            lbl_log.Text = "Wellcome: " + log;
             logName = log;
        }
       

        private void frm_admin_dashboard_Load(object sender, EventArgs e)
        {
            if(ulog.type == "A")                     // Admin authorized methods //
            {
                btn_userAccount.Visible = true;
                btn_customerAccount.Visible = true;
                btn_apartmnetType.Visible = true;
                btn_apartment.Visible = true;
                btn_reservation.Visible = true;
                btn_witingList.Visible = true;
                btn_payment.Visible = true;
                btn_info.Visible = false;
                btn_leaseEx.Visible = true ;

            }
            else if (ulog.type == "U")               // user  authorized methods //
            {
                btn_userAccount.Visible = false;
                btn_customerAccount.Visible = false;
                btn_apartmnetType.Visible = false;
                btn_apartment.Visible=false;
                btn_reservation.Visible = false;
                btn_witingList.Visible = false;
                btn_payment.Visible = false;
                btn_info.Visible = true;
                btn_leaseEx.Visible=false;

            }
            else if (ulog.type == "C")               // ckark  authorized methods //
            {
                btn_userAccount.Visible = false;
                btn_customerAccount.Visible = false;
                btn_apartmnetType.Visible = false;
                btn_apartment.Visible= false;
                btn_reservation.Visible = false;
                btn_witingList.Visible = true;
                btn_payment.Visible = false;
                btn_info.Visible = true;
                btn_leaseEx.Visible = true;

            }

        }

        private void btn_logout_Click(object sender, EventArgs e)  //logout//
        {
            frm_login logout = new frm_login();
            logout.Show();
            this.Hide();
        }

        private void btn_userAccount_Click(object sender, EventArgs e)
        {
            frm_manageUserAccount n1 = new frm_manageUserAccount(logName);
            n1.Show();
            this.Hide();
        }

        private void btn_customerAccount_Click(object sender, EventArgs e)
        {
            frm_CustomerAccount CA1 = new frm_CustomerAccount(logName);
            CA1.Show();
            this.Hide();
        }

        private void btn_apartmnetType_Click(object sender, EventArgs e)
        {
            frm_ApartmentType type = new frm_ApartmentType();
            type.Show();
        }

        private void btn_apartment_Click(object sender, EventArgs e)
        {
            frm_apartment a = new frm_apartment();
            a.Show();
        }

        private void btn_reservation_Click(object sender, EventArgs e)
        {
            frm_reservation r1 = new frm_reservation();
            r1.Show();
        }

        private void btn_witingList_Click(object sender, EventArgs e)
        {
            frm_waitingList W = new frm_waitingList();
            W.Show();
        }

        private void btn_payment_Click(object sender, EventArgs e)
        {
            frm_Payment P = new frm_Payment();
            P.Show();
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            frm_Info I = new frm_Info();
            I.Show();
        }

        private void btn_leaseEx_Click(object sender, EventArgs e)
        {
            frm_Lease_Extention1 L = new frm_Lease_Extention1();
            L.Show();
        }
    }
}
