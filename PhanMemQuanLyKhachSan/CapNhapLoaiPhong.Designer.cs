namespace PhanMemQuanLyKhachSan
{
    partial class frmCapNhatLoaiPhong
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
            this.lblCapNhatLoaiPhong = new System.Windows.Forms.Label();
            this.lblChonSoPhong = new System.Windows.Forms.Label();
            this.cmbChonSoPhong = new System.Windows.Forms.ComboBox();
            this.lblChonLoaiPhong = new System.Windows.Forms.Label();
            this.rdoStandard = new System.Windows.Forms.RadioButton();
            this.rdoSuperior = new System.Windows.Forms.RadioButton();
            this.rdoDeluxe = new System.Windows.Forms.RadioButton();
            this.btnLuuCapNhatLoaiPhong = new System.Windows.Forms.Button();
            this.btnHuyCapNhatLoaiPhong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCapNhatLoaiPhong
            // 
            this.lblCapNhatLoaiPhong.AutoSize = true;
            this.lblCapNhatLoaiPhong.BackColor = System.Drawing.Color.Transparent;
            this.lblCapNhatLoaiPhong.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapNhatLoaiPhong.Location = new System.Drawing.Point(145, 9);
            this.lblCapNhatLoaiPhong.Name = "lblCapNhatLoaiPhong";
            this.lblCapNhatLoaiPhong.Size = new System.Drawing.Size(248, 32);
            this.lblCapNhatLoaiPhong.TabIndex = 0;
            this.lblCapNhatLoaiPhong.Text = "Cập Nhật Loại Phòng";
            // 
            // lblChonSoPhong
            // 
            this.lblChonSoPhong.AutoSize = true;
            this.lblChonSoPhong.BackColor = System.Drawing.Color.Transparent;
            this.lblChonSoPhong.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChonSoPhong.Location = new System.Drawing.Point(64, 55);
            this.lblChonSoPhong.Name = "lblChonSoPhong";
            this.lblChonSoPhong.Size = new System.Drawing.Size(153, 26);
            this.lblChonSoPhong.TabIndex = 1;
            this.lblChonSoPhong.Text = "Chọn số phòng:";
            // 
            // cmbChonSoPhong
            // 
            this.cmbChonSoPhong.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbChonSoPhong.FormattingEnabled = true;
            this.cmbChonSoPhong.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cmbChonSoPhong.Location = new System.Drawing.Point(246, 59);
            this.cmbChonSoPhong.Name = "cmbChonSoPhong";
            this.cmbChonSoPhong.Size = new System.Drawing.Size(182, 25);
            this.cmbChonSoPhong.TabIndex = 2;
            // 
            // lblChonLoaiPhong
            // 
            this.lblChonLoaiPhong.AutoSize = true;
            this.lblChonLoaiPhong.BackColor = System.Drawing.Color.Transparent;
            this.lblChonLoaiPhong.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChonLoaiPhong.Location = new System.Drawing.Point(64, 111);
            this.lblChonLoaiPhong.Name = "lblChonLoaiPhong";
            this.lblChonLoaiPhong.Size = new System.Drawing.Size(246, 26);
            this.lblChonLoaiPhong.TabIndex = 3;
            this.lblChonLoaiPhong.Text = "Chọn loại phòng thay đổi:";
            // 
            // rdoStandard
            // 
            this.rdoStandard.AutoSize = true;
            this.rdoStandard.BackColor = System.Drawing.Color.Transparent;
            this.rdoStandard.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoStandard.Location = new System.Drawing.Point(104, 154);
            this.rdoStandard.Name = "rdoStandard";
            this.rdoStandard.Size = new System.Drawing.Size(91, 26);
            this.rdoStandard.TabIndex = 4;
            this.rdoStandard.TabStop = true;
            this.rdoStandard.Text = "Standard";
            this.rdoStandard.UseVisualStyleBackColor = false;
            // 
            // rdoSuperior
            // 
            this.rdoSuperior.AutoSize = true;
            this.rdoSuperior.BackColor = System.Drawing.Color.Transparent;
            this.rdoSuperior.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSuperior.Location = new System.Drawing.Point(246, 154);
            this.rdoSuperior.Name = "rdoSuperior";
            this.rdoSuperior.Size = new System.Drawing.Size(86, 26);
            this.rdoSuperior.TabIndex = 5;
            this.rdoSuperior.TabStop = true;
            this.rdoSuperior.Text = "Superior";
            this.rdoSuperior.UseVisualStyleBackColor = false;
            // 
            // rdoDeluxe
            // 
            this.rdoDeluxe.AutoSize = true;
            this.rdoDeluxe.BackColor = System.Drawing.Color.Transparent;
            this.rdoDeluxe.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDeluxe.Location = new System.Drawing.Point(398, 154);
            this.rdoDeluxe.Name = "rdoDeluxe";
            this.rdoDeluxe.Size = new System.Drawing.Size(75, 26);
            this.rdoDeluxe.TabIndex = 6;
            this.rdoDeluxe.TabStop = true;
            this.rdoDeluxe.Text = "Deluxe";
            this.rdoDeluxe.UseVisualStyleBackColor = false;
            // 
            // btnLuuCapNhatLoaiPhong
            // 
            this.btnLuuCapNhatLoaiPhong.BackColor = System.Drawing.Color.AliceBlue;
            this.btnLuuCapNhatLoaiPhong.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuCapNhatLoaiPhong.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconLuu;
            this.btnLuuCapNhatLoaiPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuCapNhatLoaiPhong.Location = new System.Drawing.Point(127, 209);
            this.btnLuuCapNhatLoaiPhong.Name = "btnLuuCapNhatLoaiPhong";
            this.btnLuuCapNhatLoaiPhong.Size = new System.Drawing.Size(109, 40);
            this.btnLuuCapNhatLoaiPhong.TabIndex = 7;
            this.btnLuuCapNhatLoaiPhong.Text = "SAVE";
            this.btnLuuCapNhatLoaiPhong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuuCapNhatLoaiPhong.UseVisualStyleBackColor = false;
            // 
            // btnHuyCapNhatLoaiPhong
            // 
            this.btnHuyCapNhatLoaiPhong.BackColor = System.Drawing.Color.AliceBlue;
            this.btnHuyCapNhatLoaiPhong.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyCapNhatLoaiPhong.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconHuy;
            this.btnHuyCapNhatLoaiPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyCapNhatLoaiPhong.Location = new System.Drawing.Point(274, 209);
            this.btnHuyCapNhatLoaiPhong.Name = "btnHuyCapNhatLoaiPhong";
            this.btnHuyCapNhatLoaiPhong.Size = new System.Drawing.Size(119, 40);
            this.btnHuyCapNhatLoaiPhong.TabIndex = 8;
            this.btnHuyCapNhatLoaiPhong.Text = "CANCEL";
            this.btnHuyCapNhatLoaiPhong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuyCapNhatLoaiPhong.UseVisualStyleBackColor = false;
            this.btnHuyCapNhatLoaiPhong.Click += new System.EventHandler(this.btnHuyCapNhatLoaiPhong_Click);
            // 
            // frmCapNhatLoaiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PhanMemQuanLyKhachSan.Properties.Resources.ou_dormir_phuket_ile_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(518, 261);
            this.Controls.Add(this.btnHuyCapNhatLoaiPhong);
            this.Controls.Add(this.btnLuuCapNhatLoaiPhong);
            this.Controls.Add(this.rdoDeluxe);
            this.Controls.Add(this.rdoSuperior);
            this.Controls.Add(this.rdoStandard);
            this.Controls.Add(this.lblChonLoaiPhong);
            this.Controls.Add(this.cmbChonSoPhong);
            this.Controls.Add(this.lblChonSoPhong);
            this.Controls.Add(this.lblCapNhatLoaiPhong);
            this.Name = "frmCapNhatLoaiPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập Nhật Loại Phòng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCapNhatLoaiPhong;
        private System.Windows.Forms.Label lblChonSoPhong;
        private System.Windows.Forms.ComboBox cmbChonSoPhong;
        private System.Windows.Forms.Label lblChonLoaiPhong;
        private System.Windows.Forms.RadioButton rdoStandard;
        private System.Windows.Forms.RadioButton rdoSuperior;
        private System.Windows.Forms.RadioButton rdoDeluxe;
        private System.Windows.Forms.Button btnLuuCapNhatLoaiPhong;
        private System.Windows.Forms.Button btnHuyCapNhatLoaiPhong;
    }
}