namespace WindowsFormsApp1
{
    partial class frm_waitingList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_waitingList));
            this.dgv_WL = new System.Windows.Forms.DataGridView();
            this.lbl_CName = new System.Windows.Forms.Label();
            this.lbl_AType = new System.Windows.Forms.Label();
            this.lbl_details = new System.Windows.Forms.Label();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.cmb_AType = new System.Windows.Forms.ComboBox();
            this.txt_details = new System.Windows.Forms.TextBox();
            this.txt_CName = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_SAll = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_WL)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_WL
            // 
            this.dgv_WL.BackgroundColor = System.Drawing.Color.OldLace;
            this.dgv_WL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_WL.Location = new System.Drawing.Point(484, 120);
            this.dgv_WL.Name = "dgv_WL";
            this.dgv_WL.RowHeadersWidth = 51;
            this.dgv_WL.RowTemplate.Height = 24;
            this.dgv_WL.Size = new System.Drawing.Size(855, 364);
            this.dgv_WL.TabIndex = 0;
            this.dgv_WL.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_WL_CellContentClick);
            // 
            // lbl_CName
            // 
            this.lbl_CName.AutoSize = true;
            this.lbl_CName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CName.Location = new System.Drawing.Point(36, 120);
            this.lbl_CName.Name = "lbl_CName";
            this.lbl_CName.Size = new System.Drawing.Size(160, 25);
            this.lbl_CName.TabIndex = 1;
            this.lbl_CName.Text = "Customer Name:";
            // 
            // lbl_AType
            // 
            this.lbl_AType.AutoSize = true;
            this.lbl_AType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AType.Location = new System.Drawing.Point(38, 201);
            this.lbl_AType.Name = "lbl_AType";
            this.lbl_AType.Size = new System.Drawing.Size(158, 25);
            this.lbl_AType.TabIndex = 2;
            this.lbl_AType.Text = "Apartment Type:";
            // 
            // lbl_details
            // 
            this.lbl_details.AutoSize = true;
            this.lbl_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_details.Location = new System.Drawing.Point(119, 282);
            this.lbl_details.Name = "lbl_details";
            this.lbl_details.Size = new System.Drawing.Size(77, 25);
            this.lbl_details.TabIndex = 3;
            this.lbl_details.Text = "Details:";
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phone.Location = new System.Drawing.Point(121, 363);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(75, 25);
            this.lbl_phone.TabIndex = 4;
            this.lbl_phone.Text = "Phone:";
            // 
            // cmb_AType
            // 
            this.cmb_AType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_AType.FormattingEnabled = true;
            this.cmb_AType.Location = new System.Drawing.Point(202, 205);
            this.cmb_AType.Name = "cmb_AType";
            this.cmb_AType.Size = new System.Drawing.Size(249, 33);
            this.cmb_AType.TabIndex = 7;
            // 
            // txt_details
            // 
            this.txt_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_details.Location = new System.Drawing.Point(202, 282);
            this.txt_details.Name = "txt_details";
            this.txt_details.Size = new System.Drawing.Size(249, 30);
            this.txt_details.TabIndex = 8;
            // 
            // txt_CName
            // 
            this.txt_CName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CName.Location = new System.Drawing.Point(202, 124);
            this.txt_CName.Name = "txt_CName";
            this.txt_CName.Size = new System.Drawing.Size(249, 30);
            this.txt_CName.TabIndex = 9;
            // 
            // txt_phone
            // 
            this.txt_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phone.Location = new System.Drawing.Point(202, 367);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(249, 30);
            this.txt_phone.TabIndex = 10;
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(484, 50);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(497, 30);
            this.txt_search.TabIndex = 11;
            // 
            // btn_new
            // 
            this.btn_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.Location = new System.Drawing.Point(3, 3);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(290, 44);
            this.btn_new.TabIndex = 12;
            this.btn_new.Text = "New";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(998, 50);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(181, 30);
            this.btn_search.TabIndex = 13;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(299, 3);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(290, 44);
            this.btn_update.TabIndex = 14;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(595, 3);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(290, 44);
            this.btn_delete.TabIndex = 15;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_SAll
            // 
            this.btn_SAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SAll.Location = new System.Drawing.Point(1200, 50);
            this.btn_SAll.Name = "btn_SAll";
            this.btn_SAll.Size = new System.Drawing.Size(139, 30);
            this.btn_SAll.TabIndex = 16;
            this.btn_SAll.Text = "Show All";
            this.btn_SAll.UseVisualStyleBackColor = true;
            this.btn_SAll.Click += new System.EventHandler(this.btn_SAll_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btn_exit, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_new, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_delete, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_update, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(116, 531);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1185, 50);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_exit.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(891, 3);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(291, 44);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // frm_waitingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1369, 668);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btn_SAll);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.txt_CName);
            this.Controls.Add(this.txt_details);
            this.Controls.Add(this.cmb_AType);
            this.Controls.Add(this.lbl_phone);
            this.Controls.Add(this.lbl_details);
            this.Controls.Add(this.lbl_AType);
            this.Controls.Add(this.lbl_CName);
            this.Controls.Add(this.dgv_WL);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_waitingList";
            this.Text = "Waiting List";
            this.Load += new System.EventHandler(this.Waiting_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_WL)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_WL;
        private System.Windows.Forms.Label lbl_CName;
        private System.Windows.Forms.Label lbl_AType;
        private System.Windows.Forms.Label lbl_details;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.ComboBox cmb_AType;
        private System.Windows.Forms.TextBox txt_details;
        private System.Windows.Forms.TextBox txt_CName;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_SAll;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_exit;
    }
}