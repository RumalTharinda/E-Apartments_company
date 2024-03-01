namespace WindowsFormsApp1
{
    partial class frm_apartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_apartment));
            this.lbl_AID = new System.Windows.Forms.Label();
            this.lbl_BID = new System.Windows.Forms.Label();
            this.lbl_BAID = new System.Windows.Forms.Label();
            this.lbl_AT = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.lbl_AS = new System.Windows.Forms.Label();
            this.lbl_COP = new System.Windows.Forms.Label();
            this.lbl_TP = new System.Windows.Forms.Label();
            this.lbl_MP = new System.Windows.Forms.Label();
            this.lbl_APS = new System.Windows.Forms.Label();
            this.txt_AID = new System.Windows.Forms.TextBox();
            this.txt_BID = new System.Windows.Forms.TextBox();
            this.txt_BAID = new System.Windows.Forms.TextBox();
            this.cmb_AT = new System.Windows.Forms.ComboBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.cmb_AS = new System.Windows.Forms.ComboBox();
            this.cmb_COP = new System.Windows.Forms.ComboBox();
            this.txt_TP = new System.Windows.Forms.TextBox();
            this.cmb_MP = new System.Windows.Forms.ComboBox();
            this.cmb_APS = new System.Windows.Forms.ComboBox();
            this.dgv_AP = new System.Windows.Forms.DataGridView();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_showAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AP)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_AID
            // 
            this.lbl_AID.AutoSize = true;
            this.lbl_AID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AID.Location = new System.Drawing.Point(157, 107);
            this.lbl_AID.Name = "lbl_AID";
            this.lbl_AID.Size = new System.Drawing.Size(126, 20);
            this.lbl_AID.TabIndex = 0;
            this.lbl_AID.Text = "Apartment ID:";
            this.lbl_AID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_BID
            // 
            this.lbl_BID.AutoSize = true;
            this.lbl_BID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BID.Location = new System.Drawing.Point(175, 162);
            this.lbl_BID.Name = "lbl_BID";
            this.lbl_BID.Size = new System.Drawing.Size(108, 20);
            this.lbl_BID.TabIndex = 1;
            this.lbl_BID.Text = "Building ID:";
            this.lbl_BID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_BAID
            // 
            this.lbl_BAID.AutoSize = true;
            this.lbl_BAID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BAID.Location = new System.Drawing.Point(68, 216);
            this.lbl_BAID.Name = "lbl_BAID";
            this.lbl_BAID.Size = new System.Drawing.Size(200, 20);
            this.lbl_BAID.TabIndex = 2;
            this.lbl_BAID.Text = "Building Apartment ID:";
            this.lbl_BAID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_AT
            // 
            this.lbl_AT.AutoSize = true;
            this.lbl_AT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AT.Location = new System.Drawing.Point(121, 272);
            this.lbl_AT.Name = "lbl_AT";
            this.lbl_AT.Size = new System.Drawing.Size(147, 20);
            this.lbl_AT.TabIndex = 3;
            this.lbl_AT.Text = "Apartment Type:";
            this.lbl_AT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_address.Location = new System.Drawing.Point(199, 327);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(84, 20);
            this.lbl_address.TabIndex = 4;
            this.lbl_address.Text = "Address:";
            this.lbl_address.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phone.Location = new System.Drawing.Point(216, 382);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(67, 20);
            this.lbl_phone.TabIndex = 5;
            this.lbl_phone.Text = "Phone:";
            this.lbl_phone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_AS
            // 
            this.lbl_AS.AutoSize = true;
            this.lbl_AS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AS.Location = new System.Drawing.Point(132, 437);
            this.lbl_AS.Name = "lbl_AS";
            this.lbl_AS.Size = new System.Drawing.Size(151, 20);
            this.lbl_AS.TabIndex = 6;
            this.lbl_AS.Text = "Apartment State:";
            this.lbl_AS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_COP
            // 
            this.lbl_COP.AutoSize = true;
            this.lbl_COP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_COP.Location = new System.Drawing.Point(138, 492);
            this.lbl_COP.Name = "lbl_COP";
            this.lbl_COP.Size = new System.Drawing.Size(145, 20);
            this.lbl_COP.TabIndex = 7;
            this.lbl_COP.Text = "Chief Occupant:";
            this.lbl_COP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_TP
            // 
            this.lbl_TP.AutoSize = true;
            this.lbl_TP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TP.Location = new System.Drawing.Point(167, 547);
            this.lbl_TP.Name = "lbl_TP";
            this.lbl_TP.Size = new System.Drawing.Size(116, 20);
            this.lbl_TP.TabIndex = 8;
            this.lbl_TP.Text = "Time Period:";
            this.lbl_TP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_MP
            // 
            this.lbl_MP.AutoSize = true;
            this.lbl_MP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MP.Location = new System.Drawing.Point(171, 602);
            this.lbl_MP.Name = "lbl_MP";
            this.lbl_MP.Size = new System.Drawing.Size(112, 20);
            this.lbl_MP.TabIndex = 9;
            this.lbl_MP.Text = "Max People:";
            this.lbl_MP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_APS
            // 
            this.lbl_APS.AutoSize = true;
            this.lbl_APS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_APS.Location = new System.Drawing.Point(33, 657);
            this.lbl_APS.Name = "lbl_APS";
            this.lbl_APS.Size = new System.Drawing.Size(235, 20);
            this.lbl_APS.TabIndex = 10;
            this.lbl_APS.Text = "Additional Parcking Space:";
            this.lbl_APS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_AID
            // 
            this.txt_AID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AID.Location = new System.Drawing.Point(317, 99);
            this.txt_AID.Name = "txt_AID";
            this.txt_AID.Size = new System.Drawing.Size(286, 27);
            this.txt_AID.TabIndex = 11;
            // 
            // txt_BID
            // 
            this.txt_BID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BID.Location = new System.Drawing.Point(317, 154);
            this.txt_BID.Name = "txt_BID";
            this.txt_BID.Size = new System.Drawing.Size(286, 27);
            this.txt_BID.TabIndex = 12;
            // 
            // txt_BAID
            // 
            this.txt_BAID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BAID.Location = new System.Drawing.Point(317, 209);
            this.txt_BAID.Name = "txt_BAID";
            this.txt_BAID.Size = new System.Drawing.Size(286, 27);
            this.txt_BAID.TabIndex = 13;
            // 
            // cmb_AT
            // 
            this.cmb_AT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_AT.FormattingEnabled = true;
            this.cmb_AT.Location = new System.Drawing.Point(317, 264);
            this.cmb_AT.Name = "cmb_AT";
            this.cmb_AT.Size = new System.Drawing.Size(286, 28);
            this.cmb_AT.TabIndex = 14;
            // 
            // txt_address
            // 
            this.txt_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address.Location = new System.Drawing.Point(317, 319);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(286, 27);
            this.txt_address.TabIndex = 15;
            // 
            // txt_phone
            // 
            this.txt_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phone.Location = new System.Drawing.Point(317, 374);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(286, 27);
            this.txt_phone.TabIndex = 16;
            // 
            // cmb_AS
            // 
            this.cmb_AS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_AS.FormattingEnabled = true;
            this.cmb_AS.Items.AddRange(new object[] {
            "Available",
            "Occupied",
            "Unavailable",
            "Reserved"});
            this.cmb_AS.Location = new System.Drawing.Point(317, 429);
            this.cmb_AS.Name = "cmb_AS";
            this.cmb_AS.Size = new System.Drawing.Size(286, 28);
            this.cmb_AS.TabIndex = 17;
            // 
            // cmb_COP
            // 
            this.cmb_COP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_COP.FormattingEnabled = true;
            this.cmb_COP.Location = new System.Drawing.Point(317, 484);
            this.cmb_COP.Name = "cmb_COP";
            this.cmb_COP.Size = new System.Drawing.Size(286, 28);
            this.cmb_COP.TabIndex = 18;
            // 
            // txt_TP
            // 
            this.txt_TP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TP.ForeColor = System.Drawing.Color.LightGray;
            this.txt_TP.Location = new System.Drawing.Point(317, 539);
            this.txt_TP.Name = "txt_TP";
            this.txt_TP.Size = new System.Drawing.Size(286, 27);
            this.txt_TP.TabIndex = 19;
            this.txt_TP.Text = "DD/MM/YYYY to DD/MM/YYYY";
            // 
            // cmb_MP
            // 
            this.cmb_MP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_MP.FormattingEnabled = true;
            this.cmb_MP.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07"});
            this.cmb_MP.Location = new System.Drawing.Point(317, 594);
            this.cmb_MP.Name = "cmb_MP";
            this.cmb_MP.Size = new System.Drawing.Size(286, 28);
            this.cmb_MP.TabIndex = 20;
            // 
            // cmb_APS
            // 
            this.cmb_APS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_APS.FormattingEnabled = true;
            this.cmb_APS.Items.AddRange(new object[] {
            "01",
            "02",
            "03"});
            this.cmb_APS.Location = new System.Drawing.Point(317, 649);
            this.cmb_APS.Name = "cmb_APS";
            this.cmb_APS.Size = new System.Drawing.Size(286, 28);
            this.cmb_APS.TabIndex = 21;
            // 
            // dgv_AP
            // 
            this.dgv_AP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_AP.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dgv_AP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AP.Location = new System.Drawing.Point(622, 96);
            this.dgv_AP.Name = "dgv_AP";
            this.dgv_AP.RowHeadersWidth = 51;
            this.dgv_AP.RowTemplate.Height = 24;
            this.dgv_AP.Size = new System.Drawing.Size(1208, 512);
            this.dgv_AP.TabIndex = 22;
            this.dgv_AP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_AP_CellContentClick);
            // 
            // btn_new
            // 
            this.btn_new.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.Location = new System.Drawing.Point(3, 3);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(296, 43);
            this.btn_new.TabIndex = 23;
            this.btn_new.Text = "New";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_update
            // 
            this.btn_update.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(305, 3);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(296, 43);
            this.btn_update.TabIndex = 24;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(607, 3);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(296, 43);
            this.btn_delete.TabIndex = 25;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(909, 3);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(296, 43);
            this.btn_exit.TabIndex = 26;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btn_exit, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_update, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_delete, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_new, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(622, 628);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1208, 49);
            this.tableLayoutPanel1.TabIndex = 27;
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(1610, 43);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(217, 33);
            this.btn_search.TabIndex = 28;
            this.btn_search.Text = "Search Apartment";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(621, 46);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(987, 30);
            this.txt_search.TabIndex = 29;
            // 
            // btn_showAll
            // 
            this.btn_showAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showAll.Location = new System.Drawing.Point(317, 43);
            this.btn_showAll.Name = "btn_showAll";
            this.btn_showAll.Size = new System.Drawing.Size(286, 33);
            this.btn_showAll.TabIndex = 30;
            this.btn_showAll.Text = "Show All";
            this.btn_showAll.UseVisualStyleBackColor = true;
            this.btn_showAll.Click += new System.EventHandler(this.btn_showAll_Click);
            // 
            // frm_apartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1900, 753);
            this.Controls.Add(this.btn_showAll);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dgv_AP);
            this.Controls.Add(this.cmb_APS);
            this.Controls.Add(this.cmb_MP);
            this.Controls.Add(this.txt_TP);
            this.Controls.Add(this.cmb_COP);
            this.Controls.Add(this.cmb_AS);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.cmb_AT);
            this.Controls.Add(this.txt_BAID);
            this.Controls.Add(this.txt_BID);
            this.Controls.Add(this.txt_AID);
            this.Controls.Add(this.lbl_APS);
            this.Controls.Add(this.lbl_MP);
            this.Controls.Add(this.lbl_TP);
            this.Controls.Add(this.lbl_COP);
            this.Controls.Add(this.lbl_AS);
            this.Controls.Add(this.lbl_phone);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.lbl_AT);
            this.Controls.Add(this.lbl_BAID);
            this.Controls.Add(this.lbl_BID);
            this.Controls.Add(this.lbl_AID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(3000, 1000);
            this.MinimumSize = new System.Drawing.Size(1918, 750);
            this.Name = "frm_apartment";
            this.Text = "Apartment";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_apartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AP)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_AID;
        private System.Windows.Forms.Label lbl_BID;
        private System.Windows.Forms.Label lbl_BAID;
        private System.Windows.Forms.Label lbl_AT;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.Label lbl_AS;
        private System.Windows.Forms.Label lbl_COP;
        private System.Windows.Forms.Label lbl_TP;
        private System.Windows.Forms.Label lbl_MP;
        private System.Windows.Forms.Label lbl_APS;
        private System.Windows.Forms.TextBox txt_AID;
        private System.Windows.Forms.TextBox txt_BID;
        private System.Windows.Forms.TextBox txt_BAID;
        private System.Windows.Forms.ComboBox cmb_AT;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.ComboBox cmb_AS;
        private System.Windows.Forms.ComboBox cmb_COP;
        private System.Windows.Forms.TextBox txt_TP;
        private System.Windows.Forms.ComboBox cmb_MP;
        private System.Windows.Forms.ComboBox cmb_APS;
        private System.Windows.Forms.DataGridView dgv_AP;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_showAll;
    }
}