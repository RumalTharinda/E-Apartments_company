namespace WindowsFormsApp1
{
    partial class frm_Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Info));
            this.dgv_info = new System.Windows.Forms.DataGridView();
            this.btn_availableApartment = new System.Windows.Forms.Button();
            this.btn_waitingList = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_info)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_info
            // 
            this.dgv_info.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.dgv_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_info.Location = new System.Drawing.Point(43, 79);
            this.dgv_info.Name = "dgv_info";
            this.dgv_info.RowHeadersWidth = 51;
            this.dgv_info.RowTemplate.Height = 24;
            this.dgv_info.Size = new System.Drawing.Size(1583, 340);
            this.dgv_info.TabIndex = 0;
            // 
            // btn_availableApartment
            // 
            this.btn_availableApartment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_availableApartment.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_availableApartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_availableApartment.Location = new System.Drawing.Point(3, 3);
            this.btn_availableApartment.Name = "btn_availableApartment";
            this.btn_availableApartment.Size = new System.Drawing.Size(785, 51);
            this.btn_availableApartment.TabIndex = 1;
            this.btn_availableApartment.Text = "Available Apartment";
            this.btn_availableApartment.UseVisualStyleBackColor = false;
            this.btn_availableApartment.Click += new System.EventHandler(this.btn_availableApartment_Click);
            // 
            // btn_waitingList
            // 
            this.btn_waitingList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_waitingList.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_waitingList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_waitingList.Location = new System.Drawing.Point(794, 3);
            this.btn_waitingList.Name = "btn_waitingList";
            this.btn_waitingList.Size = new System.Drawing.Size(786, 51);
            this.btn_waitingList.TabIndex = 2;
            this.btn_waitingList.Text = "Waiting List";
            this.btn_waitingList.UseVisualStyleBackColor = false;
            this.btn_waitingList.Click += new System.EventHandler(this.btn_waitingList_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btn_waitingList, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_availableApartment, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(43, 437);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1583, 57);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // frm_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1682, 537);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dgv_info);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(2000, 584);
            this.MinimumSize = new System.Drawing.Size(1700, 584);
            this.Name = "frm_Info";
            this.Text = "Info";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_info)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_info;
        private System.Windows.Forms.Button btn_availableApartment;
        private System.Windows.Forms.Button btn_waitingList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}