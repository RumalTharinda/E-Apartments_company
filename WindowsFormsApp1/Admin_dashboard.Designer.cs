namespace WindowsFormsApp1
{
    partial class frm_dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_dashboard));
            this.lbl_log = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_companyName = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_leaseEx = new System.Windows.Forms.Button();
            this.btn_info = new System.Windows.Forms.Button();
            this.btn_payment = new System.Windows.Forms.Button();
            this.btn_witingList = new System.Windows.Forms.Button();
            this.btn_reservation = new System.Windows.Forms.Button();
            this.btn_apartment = new System.Windows.Forms.Button();
            this.btn_apartmnetType = new System.Windows.Forms.Button();
            this.btn_customerAccount = new System.Windows.Forms.Button();
            this.btn_userAccount = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_log
            // 
            this.lbl_log.AutoSize = true;
            this.lbl_log.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_log.ForeColor = System.Drawing.Color.Black;
            this.lbl_log.Location = new System.Drawing.Point(726, 9);
            this.lbl_log.Name = "lbl_log";
            this.lbl_log.Size = new System.Drawing.Size(88, 22);
            this.lbl_log.TabIndex = 0;
            this.lbl_log.Text = "Welcome:";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(37)))), ((int)(((byte)(147)))));
            this.panelMenu.Controls.Add(this.btn_leaseEx);
            this.panelMenu.Controls.Add(this.btn_info);
            this.panelMenu.Controls.Add(this.btn_payment);
            this.panelMenu.Controls.Add(this.btn_witingList);
            this.panelMenu.Controls.Add(this.btn_reservation);
            this.panelMenu.Controls.Add(this.btn_apartment);
            this.panelMenu.Controls.Add(this.btn_apartmnetType);
            this.panelMenu.Controls.Add(this.btn_customerAccount);
            this.panelMenu.Controls.Add(this.btn_userAccount);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(237, 642);
            this.panelMenu.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(37)))), ((int)(((byte)(147)))));
            this.panel1.Controls.Add(this.lbl_companyName);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Goldenrod;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 133);
            this.panel1.TabIndex = 0;
            // 
            // lbl_companyName
            // 
            this.lbl_companyName.AutoSize = true;
            this.lbl_companyName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(37)))), ((int)(((byte)(147)))));
            this.lbl_companyName.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_companyName.ForeColor = System.Drawing.Color.Gold;
            this.lbl_companyName.Location = new System.Drawing.Point(12, 97);
            this.lbl_companyName.Name = "lbl_companyName";
            this.lbl_companyName.Size = new System.Drawing.Size(209, 34);
            this.lbl_companyName.TabIndex = 0;
            this.lbl_companyName.Text = "‘E-Apartments";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.MediumOrchid;
            this.panelTitleBar.Controls.Add(this.btn_logout);
            this.panelTitleBar.Controls.Add(this.lbl_log);
            this.panelTitleBar.Controls.Add(this.label1);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(237, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1159, 82);
            this.panelTitleBar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "DASHBOARD";
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.MediumPurple;
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDesktop.ForeColor = System.Drawing.Color.Gold;
            this.panelDesktop.Location = new System.Drawing.Point(237, 82);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1159, 560);
            this.panelDesktop.TabIndex = 3;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btn_logout
            // 
            this.btn_logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_logout.BackColor = System.Drawing.Color.MediumOrchid;
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.Gold;
            this.btn_logout.Image = ((System.Drawing.Image)(resources.GetObject("btn_logout.Image")));
            this.btn_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_logout.Location = new System.Drawing.Point(976, 6);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(171, 48);
            this.btn_logout.TabIndex = 1;
            this.btn_logout.Text = "Log out";
            this.btn_logout.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_leaseEx
            // 
            this.btn_leaseEx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(37)))), ((int)(((byte)(147)))));
            this.btn_leaseEx.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_leaseEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_leaseEx.ForeColor = System.Drawing.Color.Gold;
            this.btn_leaseEx.Image = global::WindowsFormsApp1.Properties.Resources.LE;
            this.btn_leaseEx.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_leaseEx.Location = new System.Drawing.Point(0, 533);
            this.btn_leaseEx.Name = "btn_leaseEx";
            this.btn_leaseEx.Size = new System.Drawing.Size(237, 50);
            this.btn_leaseEx.TabIndex = 8;
            this.btn_leaseEx.Text = "Lease Extension";
            this.btn_leaseEx.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_leaseEx.UseVisualStyleBackColor = false;
            this.btn_leaseEx.Click += new System.EventHandler(this.btn_leaseEx_Click);
            // 
            // btn_info
            // 
            this.btn_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(37)))), ((int)(((byte)(147)))));
            this.btn_info.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_info.ForeColor = System.Drawing.Color.Gold;
            this.btn_info.Image = global::WindowsFormsApp1.Properties.Resources.info;
            this.btn_info.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_info.Location = new System.Drawing.Point(0, 483);
            this.btn_info.Name = "btn_info";
            this.btn_info.Size = new System.Drawing.Size(237, 50);
            this.btn_info.TabIndex = 7;
            this.btn_info.Text = "Information";
            this.btn_info.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_info.UseVisualStyleBackColor = false;
            this.btn_info.Click += new System.EventHandler(this.btn_info_Click);
            // 
            // btn_payment
            // 
            this.btn_payment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(37)))), ((int)(((byte)(147)))));
            this.btn_payment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_payment.ForeColor = System.Drawing.Color.Gold;
            this.btn_payment.Image = global::WindowsFormsApp1.Properties.Resources.favicon_32x32;
            this.btn_payment.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_payment.Location = new System.Drawing.Point(0, 433);
            this.btn_payment.Name = "btn_payment";
            this.btn_payment.Size = new System.Drawing.Size(237, 50);
            this.btn_payment.TabIndex = 6;
            this.btn_payment.Text = "Payment";
            this.btn_payment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_payment.UseVisualStyleBackColor = false;
            this.btn_payment.Click += new System.EventHandler(this.btn_payment_Click);
            // 
            // btn_witingList
            // 
            this.btn_witingList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(37)))), ((int)(((byte)(147)))));
            this.btn_witingList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_witingList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_witingList.ForeColor = System.Drawing.Color.Gold;
            this.btn_witingList.Image = global::WindowsFormsApp1.Properties.Resources.btn6;
            this.btn_witingList.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_witingList.Location = new System.Drawing.Point(0, 383);
            this.btn_witingList.Name = "btn_witingList";
            this.btn_witingList.Size = new System.Drawing.Size(237, 50);
            this.btn_witingList.TabIndex = 5;
            this.btn_witingList.Text = "Waiting List";
            this.btn_witingList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_witingList.UseVisualStyleBackColor = false;
            this.btn_witingList.Click += new System.EventHandler(this.btn_witingList_Click);
            // 
            // btn_reservation
            // 
            this.btn_reservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(37)))), ((int)(((byte)(147)))));
            this.btn_reservation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_reservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reservation.ForeColor = System.Drawing.Color.Gold;
            this.btn_reservation.Image = global::WindowsFormsApp1.Properties.Resources.btn5;
            this.btn_reservation.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_reservation.Location = new System.Drawing.Point(0, 333);
            this.btn_reservation.Name = "btn_reservation";
            this.btn_reservation.Size = new System.Drawing.Size(237, 50);
            this.btn_reservation.TabIndex = 4;
            this.btn_reservation.Text = "Reservation";
            this.btn_reservation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_reservation.UseVisualStyleBackColor = false;
            this.btn_reservation.Click += new System.EventHandler(this.btn_reservation_Click);
            // 
            // btn_apartment
            // 
            this.btn_apartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(37)))), ((int)(((byte)(147)))));
            this.btn_apartment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_apartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_apartment.ForeColor = System.Drawing.Color.Gold;
            this.btn_apartment.Image = global::WindowsFormsApp1.Properties.Resources.btn3;
            this.btn_apartment.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_apartment.Location = new System.Drawing.Point(0, 283);
            this.btn_apartment.Name = "btn_apartment";
            this.btn_apartment.Size = new System.Drawing.Size(237, 50);
            this.btn_apartment.TabIndex = 3;
            this.btn_apartment.Text = "Apartment ";
            this.btn_apartment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_apartment.UseVisualStyleBackColor = false;
            this.btn_apartment.Click += new System.EventHandler(this.btn_apartment_Click);
            // 
            // btn_apartmnetType
            // 
            this.btn_apartmnetType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(37)))), ((int)(((byte)(147)))));
            this.btn_apartmnetType.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_apartmnetType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_apartmnetType.ForeColor = System.Drawing.Color.Gold;
            this.btn_apartmnetType.Image = global::WindowsFormsApp1.Properties.Resources.btn1;
            this.btn_apartmnetType.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_apartmnetType.Location = new System.Drawing.Point(0, 233);
            this.btn_apartmnetType.Name = "btn_apartmnetType";
            this.btn_apartmnetType.Size = new System.Drawing.Size(237, 50);
            this.btn_apartmnetType.TabIndex = 2;
            this.btn_apartmnetType.Text = "Apartment Type";
            this.btn_apartmnetType.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_apartmnetType.UseVisualStyleBackColor = false;
            this.btn_apartmnetType.Click += new System.EventHandler(this.btn_apartmnetType_Click);
            // 
            // btn_customerAccount
            // 
            this.btn_customerAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(37)))), ((int)(((byte)(147)))));
            this.btn_customerAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_customerAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customerAccount.ForeColor = System.Drawing.Color.Gold;
            this.btn_customerAccount.Image = global::WindowsFormsApp1.Properties.Resources.btn4;
            this.btn_customerAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_customerAccount.Location = new System.Drawing.Point(0, 183);
            this.btn_customerAccount.Name = "btn_customerAccount";
            this.btn_customerAccount.Size = new System.Drawing.Size(237, 50);
            this.btn_customerAccount.TabIndex = 1;
            this.btn_customerAccount.Text = " Customer Account";
            this.btn_customerAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_customerAccount.UseVisualStyleBackColor = false;
            this.btn_customerAccount.Click += new System.EventHandler(this.btn_customerAccount_Click);
            // 
            // btn_userAccount
            // 
            this.btn_userAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(37)))), ((int)(((byte)(147)))));
            this.btn_userAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_userAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_userAccount.ForeColor = System.Drawing.Color.Gold;
            this.btn_userAccount.Image = ((System.Drawing.Image)(resources.GetObject("btn_userAccount.Image")));
            this.btn_userAccount.Location = new System.Drawing.Point(0, 133);
            this.btn_userAccount.Name = "btn_userAccount";
            this.btn_userAccount.Size = new System.Drawing.Size(237, 50);
            this.btn_userAccount.TabIndex = 0;
            this.btn_userAccount.Text = "User Account";
            this.btn_userAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_userAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_userAccount.UseVisualStyleBackColor = false;
            this.btn_userAccount.Click += new System.EventHandler(this.btn_userAccount_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frm_dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 642);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_dashboard";
            this.Text = "Home page";
            this.Load += new System.EventHandler(this.frm_admin_dashboard_Load);
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_log;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Label lbl_companyName;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_userAccount;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_customerAccount;
        private System.Windows.Forms.Button btn_apartmnetType;
        private System.Windows.Forms.Button btn_apartment;
        private System.Windows.Forms.Button btn_reservation;
        private System.Windows.Forms.Button btn_witingList;
        private System.Windows.Forms.Button btn_payment;
        private System.Windows.Forms.Button btn_info;
        private System.Windows.Forms.Button btn_leaseEx;
    }
}