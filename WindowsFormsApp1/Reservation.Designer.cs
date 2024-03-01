namespace WindowsFormsApp1
{
    partial class frm_reservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_reservation));
            this.dgv_reservation = new System.Windows.Forms.DataGridView();
            this.btn_AA = new System.Windows.Forms.Button();
            this.btn_WL = new System.Windows.Forms.Button();
            this.cmb_Chief_Occupant = new System.Windows.Forms.ComboBox();
            this.cmb_Apartment_State = new System.Windows.Forms.ComboBox();
            this.lbl_Apartment_State = new System.Windows.Forms.Label();
            this.lbl_Chief_Occupant = new System.Windows.Forms.Label();
            this.btn_reserve = new System.Windows.Forms.Button();
            this.btn_Payment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reservation)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_reservation
            // 
            this.dgv_reservation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_reservation.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dgv_reservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_reservation.Location = new System.Drawing.Point(24, 31);
            this.dgv_reservation.Name = "dgv_reservation";
            this.dgv_reservation.RowHeadersWidth = 51;
            this.dgv_reservation.RowTemplate.Height = 24;
            this.dgv_reservation.Size = new System.Drawing.Size(1870, 448);
            this.dgv_reservation.TabIndex = 0;
            this.dgv_reservation.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_reservation_CellDoubleClick);
            // 
            // btn_AA
            // 
            this.btn_AA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AA.BackColor = System.Drawing.Color.Lavender;
            this.btn_AA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AA.Location = new System.Drawing.Point(24, 671);
            this.btn_AA.Name = "btn_AA";
            this.btn_AA.Size = new System.Drawing.Size(1870, 54);
            this.btn_AA.TabIndex = 1;
            this.btn_AA.Text = "Available Apartment";
            this.btn_AA.UseVisualStyleBackColor = false;
            this.btn_AA.Click += new System.EventHandler(this.btn_AA_Click);
            // 
            // btn_WL
            // 
            this.btn_WL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_WL.BackColor = System.Drawing.Color.Lavender;
            this.btn_WL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_WL.Location = new System.Drawing.Point(24, 861);
            this.btn_WL.Name = "btn_WL";
            this.btn_WL.Size = new System.Drawing.Size(1870, 54);
            this.btn_WL.TabIndex = 2;
            this.btn_WL.Text = "Waiting List";
            this.btn_WL.UseVisualStyleBackColor = false;
            this.btn_WL.Click += new System.EventHandler(this.btn_WL_Click);
            // 
            // cmb_Chief_Occupant
            // 
            this.cmb_Chief_Occupant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmb_Chief_Occupant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Chief_Occupant.FormattingEnabled = true;
            this.cmb_Chief_Occupant.Location = new System.Drawing.Point(257, 587);
            this.cmb_Chief_Occupant.Name = "cmb_Chief_Occupant";
            this.cmb_Chief_Occupant.Size = new System.Drawing.Size(328, 33);
            this.cmb_Chief_Occupant.TabIndex = 3;
            // 
            // cmb_Apartment_State
            // 
            this.cmb_Apartment_State.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmb_Apartment_State.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Apartment_State.FormattingEnabled = true;
            this.cmb_Apartment_State.Items.AddRange(new object[] {
            "Available",
            "Occupied",
            "Unavailable",
            "Reserved"});
            this.cmb_Apartment_State.Location = new System.Drawing.Point(867, 587);
            this.cmb_Apartment_State.Name = "cmb_Apartment_State";
            this.cmb_Apartment_State.Size = new System.Drawing.Size(328, 33);
            this.cmb_Apartment_State.TabIndex = 4;
            // 
            // lbl_Apartment_State
            // 
            this.lbl_Apartment_State.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_Apartment_State.AutoSize = true;
            this.lbl_Apartment_State.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Apartment_State.Location = new System.Drawing.Point(686, 590);
            this.lbl_Apartment_State.Name = "lbl_Apartment_State";
            this.lbl_Apartment_State.Size = new System.Drawing.Size(159, 25);
            this.lbl_Apartment_State.TabIndex = 5;
            this.lbl_Apartment_State.Text = "Apartment State:";
            // 
            // lbl_Chief_Occupant
            // 
            this.lbl_Chief_Occupant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Chief_Occupant.AutoSize = true;
            this.lbl_Chief_Occupant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Chief_Occupant.Location = new System.Drawing.Point(75, 590);
            this.lbl_Chief_Occupant.Name = "lbl_Chief_Occupant";
            this.lbl_Chief_Occupant.Size = new System.Drawing.Size(154, 25);
            this.lbl_Chief_Occupant.TabIndex = 6;
            this.lbl_Chief_Occupant.Text = "Chief Occupant:";
            // 
            // btn_reserve
            // 
            this.btn_reserve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_reserve.BackColor = System.Drawing.Color.Lavender;
            this.btn_reserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reserve.Location = new System.Drawing.Point(1330, 581);
            this.btn_reserve.Name = "btn_reserve";
            this.btn_reserve.Size = new System.Drawing.Size(462, 43);
            this.btn_reserve.TabIndex = 7;
            this.btn_reserve.Text = "Reserve";
            this.btn_reserve.UseVisualStyleBackColor = false;
            this.btn_reserve.Click += new System.EventHandler(this.btn_reserve_Click);
            // 
            // btn_Payment
            // 
            this.btn_Payment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Payment.BackColor = System.Drawing.Color.Lavender;
            this.btn_Payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Payment.Location = new System.Drawing.Point(24, 766);
            this.btn_Payment.Name = "btn_Payment";
            this.btn_Payment.Size = new System.Drawing.Size(1870, 54);
            this.btn_Payment.TabIndex = 8;
            this.btn_Payment.Text = "Payment";
            this.btn_Payment.UseVisualStyleBackColor = false;
            // 
            // frm_reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1924, 953);
            this.Controls.Add(this.btn_Payment);
            this.Controls.Add(this.btn_reserve);
            this.Controls.Add(this.lbl_Chief_Occupant);
            this.Controls.Add(this.lbl_Apartment_State);
            this.Controls.Add(this.cmb_Apartment_State);
            this.Controls.Add(this.cmb_Chief_Occupant);
            this.Controls.Add(this.btn_WL);
            this.Controls.Add(this.btn_AA);
            this.Controls.Add(this.dgv_reservation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(3000, 1000);
            this.MinimumSize = new System.Drawing.Size(1918, 1000);
            this.Name = "frm_reservation";
            this.Text = "Reservation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_reservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reservation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_reservation;
        private System.Windows.Forms.Button btn_AA;
        private System.Windows.Forms.Button btn_WL;
        private System.Windows.Forms.ComboBox cmb_Chief_Occupant;
        private System.Windows.Forms.ComboBox cmb_Apartment_State;
        private System.Windows.Forms.Label lbl_Apartment_State;
        private System.Windows.Forms.Label lbl_Chief_Occupant;
        private System.Windows.Forms.Button btn_reserve;
        private System.Windows.Forms.Button btn_Payment;
    }
}