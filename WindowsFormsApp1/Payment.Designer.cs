namespace WindowsFormsApp1
{
    partial class frm_Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Payment));
            this.lbl_CN = new System.Windows.Forms.Label();
            this.lbl_PaymentType = new System.Windows.Forms.Label();
            this.lbl_dayTime = new System.Windows.Forms.Label();
            this.lbl_Amount = new System.Windows.Forms.Label();
            this.cmb_CName = new System.Windows.Forms.ComboBox();
            this.cmb_PaymentType = new System.Windows.Forms.ComboBox();
            this.dtp_pay = new System.Windows.Forms.DateTimePicker();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.dgv_Pay = new System.Windows.Forms.DataGridView();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_showAll = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pay)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_CN
            // 
            this.lbl_CN.AutoSize = true;
            this.lbl_CN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CN.Location = new System.Drawing.Point(20, 142);
            this.lbl_CN.Name = "lbl_CN";
            this.lbl_CN.Size = new System.Drawing.Size(160, 25);
            this.lbl_CN.TabIndex = 0;
            this.lbl_CN.Text = "Customer Name:";
            // 
            // lbl_PaymentType
            // 
            this.lbl_PaymentType.AutoSize = true;
            this.lbl_PaymentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PaymentType.Location = new System.Drawing.Point(35, 222);
            this.lbl_PaymentType.Name = "lbl_PaymentType";
            this.lbl_PaymentType.Size = new System.Drawing.Size(145, 25);
            this.lbl_PaymentType.TabIndex = 1;
            this.lbl_PaymentType.Text = "Payment Type:";
            // 
            // lbl_dayTime
            // 
            this.lbl_dayTime.AutoSize = true;
            this.lbl_dayTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dayTime.Location = new System.Drawing.Point(89, 294);
            this.lbl_dayTime.Name = "lbl_dayTime";
            this.lbl_dayTime.Size = new System.Drawing.Size(97, 25);
            this.lbl_dayTime.TabIndex = 2;
            this.lbl_dayTime.Text = "DayTime:";
            // 
            // lbl_Amount
            // 
            this.lbl_Amount.AutoSize = true;
            this.lbl_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Amount.Location = new System.Drawing.Point(94, 370);
            this.lbl_Amount.Name = "lbl_Amount";
            this.lbl_Amount.Size = new System.Drawing.Size(86, 25);
            this.lbl_Amount.TabIndex = 3;
            this.lbl_Amount.Text = "Amount:";
            // 
            // cmb_CName
            // 
            this.cmb_CName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_CName.FormattingEnabled = true;
            this.cmb_CName.Location = new System.Drawing.Point(186, 139);
            this.cmb_CName.Name = "cmb_CName";
            this.cmb_CName.Size = new System.Drawing.Size(325, 33);
            this.cmb_CName.TabIndex = 4;
            // 
            // cmb_PaymentType
            // 
            this.cmb_PaymentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_PaymentType.FormattingEnabled = true;
            this.cmb_PaymentType.Items.AddRange(new object[] {
            "Monthly Rent ",
            "Refundable Deposit",
            "Reservation fee"});
            this.cmb_PaymentType.Location = new System.Drawing.Point(186, 219);
            this.cmb_PaymentType.Name = "cmb_PaymentType";
            this.cmb_PaymentType.Size = new System.Drawing.Size(325, 33);
            this.cmb_PaymentType.TabIndex = 5;
            // 
            // dtp_pay
            // 
            this.dtp_pay.CustomFormat = "dd/MM/yyyy       hh:mm:ss";
            this.dtp_pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_pay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_pay.Location = new System.Drawing.Point(186, 289);
            this.dtp_pay.Name = "dtp_pay";
            this.dtp_pay.Size = new System.Drawing.Size(325, 30);
            this.dtp_pay.TabIndex = 6;
            // 
            // txt_amount
            // 
            this.txt_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_amount.Location = new System.Drawing.Point(186, 367);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(325, 30);
            this.txt_amount.TabIndex = 7;
            // 
            // dgv_Pay
            // 
            this.dgv_Pay.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dgv_Pay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Pay.Location = new System.Drawing.Point(539, 111);
            this.dgv_Pay.Name = "dgv_Pay";
            this.dgv_Pay.RowHeadersWidth = 51;
            this.dgv_Pay.RowTemplate.Height = 24;
            this.dgv_Pay.Size = new System.Drawing.Size(922, 361);
            this.dgv_Pay.TabIndex = 8;
            this.dgv_Pay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Pay_CellContentClick);
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.Color.Aqua;
            this.btn_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.Location = new System.Drawing.Point(332, 505);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(241, 62);
            this.btn_new.TabIndex = 9;
            this.btn_new.Text = "New";
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Aqua;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(924, 505);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(241, 62);
            this.btn_delete.TabIndex = 10;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Aqua;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(628, 505);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(241, 62);
            this.btn_update.TabIndex = 11;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Aqua;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(1220, 505);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(241, 62);
            this.btn_Exit.TabIndex = 12;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(539, 40);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(693, 30);
            this.txt_search.TabIndex = 13;
            // 
            // btn_showAll
            // 
            this.btn_showAll.BackColor = System.Drawing.Color.Aqua;
            this.btn_showAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showAll.Location = new System.Drawing.Point(261, 32);
            this.btn_showAll.Name = "btn_showAll";
            this.btn_showAll.Size = new System.Drawing.Size(241, 46);
            this.btn_showAll.TabIndex = 14;
            this.btn_showAll.Text = "Show All";
            this.btn_showAll.UseVisualStyleBackColor = false;
            this.btn_showAll.Click += new System.EventHandler(this.btn_showAll_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Aqua;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(1248, 40);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(213, 30);
            this.btn_search.TabIndex = 15;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // frm_Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1491, 615);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_showAll);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.dgv_Pay);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.dtp_pay);
            this.Controls.Add(this.cmb_PaymentType);
            this.Controls.Add(this.cmb_CName);
            this.Controls.Add(this.lbl_Amount);
            this.Controls.Add(this.lbl_dayTime);
            this.Controls.Add(this.lbl_PaymentType);
            this.Controls.Add(this.lbl_CN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Payment";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_CN;
        private System.Windows.Forms.Label lbl_PaymentType;
        private System.Windows.Forms.Label lbl_dayTime;
        private System.Windows.Forms.Label lbl_Amount;
        private System.Windows.Forms.ComboBox cmb_CName;
        private System.Windows.Forms.ComboBox cmb_PaymentType;
        private System.Windows.Forms.DateTimePicker dtp_pay;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.DataGridView dgv_Pay;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_showAll;
        private System.Windows.Forms.Button btn_search;
    }
}