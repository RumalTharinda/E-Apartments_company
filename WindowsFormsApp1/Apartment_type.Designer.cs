namespace WindowsFormsApp1
{
    partial class frm_ApartmentType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ApartmentType));
            this.lbl_type = new System.Windows.Forms.Label();
            this.lbl_nBR = new System.Windows.Forms.Label();
            this.lbl_nCB = new System.Windows.Forms.Label();
            this.lbl_nAB = new System.Windows.Forms.Label();
            this.lbl_nSR = new System.Windows.Forms.Label();
            this.lbl_nST = new System.Windows.Forms.Label();
            this.txt_nBR = new System.Windows.Forms.TextBox();
            this.txt_nCBR = new System.Windows.Forms.TextBox();
            this.txt_nABR = new System.Windows.Forms.TextBox();
            this.txt_nSR = new System.Windows.Forms.TextBox();
            this.txt_nST = new System.Windows.Forms.TextBox();
            this.txt_type = new System.Windows.Forms.TextBox();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.dgv_APType = new System.Windows.Forms.DataGridView();
            this.btn_showAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_APType)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_type.Location = new System.Drawing.Point(193, 71);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(63, 25);
            this.lbl_type.TabIndex = 0;
            this.lbl_type.Text = "Type:";
            // 
            // lbl_nBR
            // 
            this.lbl_nBR.AutoSize = true;
            this.lbl_nBR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nBR.Location = new System.Drawing.Point(98, 133);
            this.lbl_nBR.Name = "lbl_nBR";
            this.lbl_nBR.Size = new System.Drawing.Size(158, 25);
            this.lbl_nBR.TabIndex = 1;
            this.lbl_nBR.Text = "No of Bedrooms:";
            // 
            // lbl_nCB
            // 
            this.lbl_nCB.AutoSize = true;
            this.lbl_nCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nCB.Location = new System.Drawing.Point(18, 195);
            this.lbl_nCB.Name = "lbl_nCB";
            this.lbl_nCB.Size = new System.Drawing.Size(238, 25);
            this.lbl_nCB.TabIndex = 2;
            this.lbl_nCB.Text = "No of Common Bathroom:";
            // 
            // lbl_nAB
            // 
            this.lbl_nAB.AutoSize = true;
            this.lbl_nAB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nAB.Location = new System.Drawing.Point(12, 257);
            this.lbl_nAB.Name = "lbl_nAB";
            this.lbl_nAB.Size = new System.Drawing.Size(244, 25);
            this.lbl_nAB.TabIndex = 3;
            this.lbl_nAB.Text = "No of Attached bathrooms:";
            // 
            // lbl_nSR
            // 
            this.lbl_nSR.AutoSize = true;
            this.lbl_nSR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nSR.Location = new System.Drawing.Point(65, 319);
            this.lbl_nSR.Name = "lbl_nSR";
            this.lbl_nSR.Size = new System.Drawing.Size(191, 25);
            this.lbl_nSR.TabIndex = 4;
            this.lbl_nSR.Text = "No of Servantsroom:";
            // 
            // lbl_nST
            // 
            this.lbl_nST.AutoSize = true;
            this.lbl_nST.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nST.Location = new System.Drawing.Point(69, 381);
            this.lbl_nST.Name = "lbl_nST";
            this.lbl_nST.Size = new System.Drawing.Size(187, 25);
            this.lbl_nST.TabIndex = 5;
            this.lbl_nST.Text = "No of Servantstoilet:";
            // 
            // txt_nBR
            // 
            this.txt_nBR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nBR.Location = new System.Drawing.Point(279, 133);
            this.txt_nBR.Name = "txt_nBR";
            this.txt_nBR.Size = new System.Drawing.Size(323, 30);
            this.txt_nBR.TabIndex = 6;
            // 
            // txt_nCBR
            // 
            this.txt_nCBR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nCBR.Location = new System.Drawing.Point(279, 195);
            this.txt_nCBR.Name = "txt_nCBR";
            this.txt_nCBR.Size = new System.Drawing.Size(323, 30);
            this.txt_nCBR.TabIndex = 7;
            // 
            // txt_nABR
            // 
            this.txt_nABR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nABR.Location = new System.Drawing.Point(279, 257);
            this.txt_nABR.Name = "txt_nABR";
            this.txt_nABR.Size = new System.Drawing.Size(323, 30);
            this.txt_nABR.TabIndex = 8;
            // 
            // txt_nSR
            // 
            this.txt_nSR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nSR.Location = new System.Drawing.Point(279, 319);
            this.txt_nSR.Name = "txt_nSR";
            this.txt_nSR.Size = new System.Drawing.Size(323, 30);
            this.txt_nSR.TabIndex = 9;
            // 
            // txt_nST
            // 
            this.txt_nST.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nST.Location = new System.Drawing.Point(279, 381);
            this.txt_nST.Name = "txt_nST";
            this.txt_nST.Size = new System.Drawing.Size(323, 30);
            this.txt_nST.TabIndex = 10;
            // 
            // txt_type
            // 
            this.txt_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_type.Location = new System.Drawing.Point(279, 71);
            this.txt_type.Name = "txt_type";
            this.txt_type.Size = new System.Drawing.Size(323, 30);
            this.txt_type.TabIndex = 11;
            // 
            // btn_new
            // 
            this.btn_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.Location = new System.Drawing.Point(34, 461);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(387, 49);
            this.btn_new.TabIndex = 12;
            this.btn_new.Text = "NEW";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(1020, 461);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(387, 49);
            this.btn_delete.TabIndex = 13;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(527, 461);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(387, 49);
            this.btn_update.TabIndex = 14;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // dgv_APType
            // 
            this.dgv_APType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_APType.Location = new System.Drawing.Point(627, 71);
            this.dgv_APType.Name = "dgv_APType";
            this.dgv_APType.RowHeadersWidth = 51;
            this.dgv_APType.RowTemplate.Height = 24;
            this.dgv_APType.Size = new System.Drawing.Size(780, 336);
            this.dgv_APType.TabIndex = 15;
            this.dgv_APType.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_APType_CellClick);
            // 
            // btn_showAll
            // 
            this.btn_showAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showAll.Location = new System.Drawing.Point(627, 31);
            this.btn_showAll.Name = "btn_showAll";
            this.btn_showAll.Size = new System.Drawing.Size(780, 34);
            this.btn_showAll.TabIndex = 16;
            this.btn_showAll.Text = "Show All Apartment Type";
            this.btn_showAll.UseVisualStyleBackColor = true;
            this.btn_showAll.Click += new System.EventHandler(this.btn_showAll_Click);
            // 
            // frm_ApartmentType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1438, 548);
            this.Controls.Add(this.btn_showAll);
            this.Controls.Add(this.dgv_APType);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.txt_type);
            this.Controls.Add(this.txt_nST);
            this.Controls.Add(this.txt_nSR);
            this.Controls.Add(this.txt_nABR);
            this.Controls.Add(this.txt_nCBR);
            this.Controls.Add(this.txt_nBR);
            this.Controls.Add(this.lbl_nST);
            this.Controls.Add(this.lbl_nSR);
            this.Controls.Add(this.lbl_nAB);
            this.Controls.Add(this.lbl_nCB);
            this.Controls.Add(this.lbl_nBR);
            this.Controls.Add(this.lbl_type);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1456, 595);
            this.MinimumSize = new System.Drawing.Size(1456, 595);
            this.Name = "frm_ApartmentType";
            this.Text = "Apartment_type";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_APType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.Label lbl_nBR;
        private System.Windows.Forms.Label lbl_nCB;
        private System.Windows.Forms.Label lbl_nAB;
        private System.Windows.Forms.Label lbl_nSR;
        private System.Windows.Forms.Label lbl_nST;
        private System.Windows.Forms.TextBox txt_nBR;
        private System.Windows.Forms.TextBox txt_nCBR;
        private System.Windows.Forms.TextBox txt_nABR;
        private System.Windows.Forms.TextBox txt_nSR;
        private System.Windows.Forms.TextBox txt_nST;
        private System.Windows.Forms.TextBox txt_type;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.DataGridView dgv_APType;
        private System.Windows.Forms.Button btn_showAll;
    }
}