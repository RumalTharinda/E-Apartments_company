namespace WindowsFormsApp1
{
    partial class frm_Lease_Extention1
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
            this.dgv_LE = new System.Windows.Forms.DataGridView();
            this.lbl_CName = new System.Windows.Forms.Label();
            this.lbl_apartmentID = new System.Windows.Forms.Label();
            this.cmb_CName = new System.Windows.Forms.ComboBox();
            this.cmb_AID = new System.Windows.Forms.ComboBox();
            this.lbl_TimePeriod = new System.Windows.Forms.Label();
            this.txt_period = new System.Windows.Forms.TextBox();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_showAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LE)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_LE
            // 
            this.dgv_LE.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dgv_LE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LE.Location = new System.Drawing.Point(52, 45);
            this.dgv_LE.Name = "dgv_LE";
            this.dgv_LE.RowHeadersWidth = 51;
            this.dgv_LE.RowTemplate.Height = 24;
            this.dgv_LE.Size = new System.Drawing.Size(1116, 279);
            this.dgv_LE.TabIndex = 0;
            this.dgv_LE.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_LE_CellDoubleClick);
            // 
            // lbl_CName
            // 
            this.lbl_CName.AutoSize = true;
            this.lbl_CName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CName.Location = new System.Drawing.Point(62, 369);
            this.lbl_CName.Name = "lbl_CName";
            this.lbl_CName.Size = new System.Drawing.Size(160, 25);
            this.lbl_CName.TabIndex = 1;
            this.lbl_CName.Text = "Customer Name:";
            // 
            // lbl_apartmentID
            // 
            this.lbl_apartmentID.AutoSize = true;
            this.lbl_apartmentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apartmentID.Location = new System.Drawing.Point(90, 433);
            this.lbl_apartmentID.Name = "lbl_apartmentID";
            this.lbl_apartmentID.Size = new System.Drawing.Size(132, 25);
            this.lbl_apartmentID.TabIndex = 2;
            this.lbl_apartmentID.Text = "Apartment ID:";
            // 
            // cmb_CName
            // 
            this.cmb_CName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_CName.FormattingEnabled = true;
            this.cmb_CName.Location = new System.Drawing.Point(242, 366);
            this.cmb_CName.Name = "cmb_CName";
            this.cmb_CName.Size = new System.Drawing.Size(301, 33);
            this.cmb_CName.TabIndex = 3;
            // 
            // cmb_AID
            // 
            this.cmb_AID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_AID.FormattingEnabled = true;
            this.cmb_AID.Location = new System.Drawing.Point(242, 425);
            this.cmb_AID.Name = "cmb_AID";
            this.cmb_AID.Size = new System.Drawing.Size(301, 33);
            this.cmb_AID.TabIndex = 4;
            // 
            // lbl_TimePeriod
            // 
            this.lbl_TimePeriod.AutoSize = true;
            this.lbl_TimePeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TimePeriod.Location = new System.Drawing.Point(99, 497);
            this.lbl_TimePeriod.Name = "lbl_TimePeriod";
            this.lbl_TimePeriod.Size = new System.Drawing.Size(123, 25);
            this.lbl_TimePeriod.TabIndex = 5;
            this.lbl_TimePeriod.Text = "Time Period:";
            // 
            // txt_period
            // 
            this.txt_period.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_period.Location = new System.Drawing.Point(242, 492);
            this.txt_period.Name = "txt_period";
            this.txt_period.Size = new System.Drawing.Size(301, 30);
            this.txt_period.TabIndex = 6;
            // 
            // btn_new
            // 
            this.btn_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.Location = new System.Drawing.Point(642, 463);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(251, 59);
            this.btn_new.TabIndex = 7;
            this.btn_new.Text = "New";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(917, 463);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(251, 59);
            this.btn_delete.TabIndex = 8;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_showAll
            // 
            this.btn_showAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showAll.Location = new System.Drawing.Point(642, 369);
            this.btn_showAll.Name = "btn_showAll";
            this.btn_showAll.Size = new System.Drawing.Size(526, 59);
            this.btn_showAll.TabIndex = 9;
            this.btn_showAll.Text = " All Lease Extention";
            this.btn_showAll.UseVisualStyleBackColor = true;
            this.btn_showAll.Click += new System.EventHandler(this.btn_showAll_Click);
            // 
            // frm_Lease_Extention1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 602);
            this.Controls.Add(this.btn_showAll);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.txt_period);
            this.Controls.Add(this.lbl_TimePeriod);
            this.Controls.Add(this.cmb_AID);
            this.Controls.Add(this.cmb_CName);
            this.Controls.Add(this.lbl_apartmentID);
            this.Controls.Add(this.lbl_CName);
            this.Controls.Add(this.dgv_LE);
            this.Name = "frm_Lease_Extention1";
            this.Text = "Lease_Extention";
            this.Load += new System.EventHandler(this.frm_Lease_Extention1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_LE;
        private System.Windows.Forms.Label lbl_CName;
        private System.Windows.Forms.Label lbl_apartmentID;
        private System.Windows.Forms.ComboBox cmb_CName;
        private System.Windows.Forms.ComboBox cmb_AID;
        private System.Windows.Forms.Label lbl_TimePeriod;
        private System.Windows.Forms.TextBox txt_period;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_showAll;
    }
}