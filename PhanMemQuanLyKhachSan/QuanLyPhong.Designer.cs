namespace PhanMemQuanLyKhachSan
{
    partial class frmQuanLyPhong
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
            this.lblQuanLyNhanVien = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvQuanLyPhong = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCapNhatDVPhong = new System.Windows.Forms.Button();
            this.btnCapNhatLoaiPhong = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCapNhatVatTu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyPhong)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuanLyNhanVien
            // 
            this.lblQuanLyNhanVien.AutoSize = true;
            this.lblQuanLyNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.lblQuanLyNhanVien.Font = new System.Drawing.Font("Palatino Linotype", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanLyNhanVien.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblQuanLyNhanVien.Location = new System.Drawing.Point(31, 16);
            this.lblQuanLyNhanVien.Name = "lblQuanLyNhanVien";
            this.lblQuanLyNhanVien.Size = new System.Drawing.Size(608, 87);
            this.lblQuanLyNhanVien.TabIndex = 8;
            this.lblQuanLyNhanVien.Text = "QUẢN LÝ PHÒNG";
            this.lblQuanLyNhanVien.Click += new System.EventHandler(this.lblQuanLyNhanVien_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(58, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "* Khách Sạn Hiện Tại Đang Có 8 Phòng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvQuanLyPhong
            // 
            this.dgvQuanLyPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuanLyPhong.BackgroundColor = System.Drawing.Color.Gray;
            this.dgvQuanLyPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLyPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.TenLoaiPhong,
            this.Gia});
            this.dgvQuanLyPhong.Location = new System.Drawing.Point(46, 158);
            this.dgvQuanLyPhong.Name = "dgvQuanLyPhong";
            this.dgvQuanLyPhong.ReadOnly = true;
            this.dgvQuanLyPhong.Size = new System.Drawing.Size(633, 383);
            this.dgvQuanLyPhong.TabIndex = 4;
            this.dgvQuanLyPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuanLyPhong_CellContentClick);
            // 
            // stt
            // 
            this.stt.FillWeight = 38.07107F;
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            // 
            // TenLoaiPhong
            // 
            this.TenLoaiPhong.FillWeight = 130.9645F;
            this.TenLoaiPhong.HeaderText = "Tên Loại Phòng";
            this.TenLoaiPhong.Name = "TenLoaiPhong";
            this.TenLoaiPhong.ReadOnly = true;
            // 
            // Gia
            // 
            this.Gia.FillWeight = 130.9645F;
            this.Gia.HeaderText = "Giá Phòng";
            this.Gia.Name = "Gia";
            this.Gia.ReadOnly = true;
            // 
            // btnCapNhatDVPhong
            // 
            this.btnCapNhatDVPhong.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnCapNhatDVPhong.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatDVPhong.Location = new System.Drawing.Point(234, 504);
            this.btnCapNhatDVPhong.Name = "btnCapNhatDVPhong";
            this.btnCapNhatDVPhong.Size = new System.Drawing.Size(218, 37);
            this.btnCapNhatDVPhong.TabIndex = 1;
            this.btnCapNhatDVPhong.Text = "Cập nhật dịch vụ";
            this.btnCapNhatDVPhong.UseVisualStyleBackColor = false;
            this.btnCapNhatDVPhong.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnCapNhatLoaiPhong
            // 
            this.btnCapNhatLoaiPhong.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnCapNhatLoaiPhong.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatLoaiPhong.Location = new System.Drawing.Point(446, 504);
            this.btnCapNhatLoaiPhong.Name = "btnCapNhatLoaiPhong";
            this.btnCapNhatLoaiPhong.Size = new System.Drawing.Size(233, 37);
            this.btnCapNhatLoaiPhong.TabIndex = 2;
            this.btnCapNhatLoaiPhong.Text = "Cập nhật loại phòng";
            this.btnCapNhatLoaiPhong.UseVisualStyleBackColor = false;
            this.btnCapNhatLoaiPhong.Click += new System.EventHandler(this.ButtonCapNhapLoaiPhong_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblQuanLyNhanVien);
            this.panel1.Controls.Add(this.btnCapNhatLoaiPhong);
            this.panel1.Controls.Add(this.btnCapNhatDVPhong);
            this.panel1.Controls.Add(this.btnCapNhatVatTu);
            this.panel1.Controls.Add(this.dgvQuanLyPhong);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(886, 789);
            this.panel1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(15, 689);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 33);
            this.label3.TabIndex = 19;
            this.label3.Text = "hotel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(15, 656);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 33);
            this.label2.TabIndex = 18;
            this.label2.Text = "Royal";
            // 
            // btnCapNhatVatTu
            // 
            this.btnCapNhatVatTu.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnCapNhatVatTu.BackgroundImage = global::PhanMemQuanLyKhachSan.Properties.Resources.pngegg;
            this.btnCapNhatVatTu.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatVatTu.Location = new System.Drawing.Point(46, 504);
            this.btnCapNhatVatTu.Name = "btnCapNhatVatTu";
            this.btnCapNhatVatTu.Size = new System.Drawing.Size(192, 37);
            this.btnCapNhatVatTu.TabIndex = 0;
            this.btnCapNhatVatTu.Text = "Cập nhật vật tư";
            this.btnCapNhatVatTu.UseVisualStyleBackColor = false;
            this.btnCapNhatVatTu.Click += new System.EventHandler(this.Button1_Click);
            // 
            // frmQuanLyPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.BackgroundImage = global::PhanMemQuanLyKhachSan.Properties.Resources.Bản_sao_Beige_Minimalist_Creative_Agency_Website_Desktop_Prototype;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1450, 780);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanLyPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Màn Hình Quản Lý Phòng";
            this.Load += new System.EventHandler(this.frmQuanLyPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyPhong)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblQuanLyNhanVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvQuanLyPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.Button btnCapNhatVatTu;
        private System.Windows.Forms.Button btnCapNhatDVPhong;
        private System.Windows.Forms.Button btnCapNhatLoaiPhong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}