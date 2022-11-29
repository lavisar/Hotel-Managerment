namespace PhanMemQuanLyKhachSan
{
    partial class frmQuanLyNhanVien
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
            this.btnCapNhatLichLamViecNV = new System.Windows.Forms.Button();
            this.btnCapNhatThongTinNV = new System.Windows.Forms.Button();
            this.lblQuanLyNhanVien = new System.Windows.Forms.Label();
            this.pnlQLNV = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLichLamViec = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaTruc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlQLNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichLamViec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCapNhatLichLamViecNV
            // 
            this.btnCapNhatLichLamViecNV.BackColor = System.Drawing.Color.Honeydew;
            this.btnCapNhatLichLamViecNV.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatLichLamViecNV.ForeColor = System.Drawing.Color.BlueViolet;
            this.btnCapNhatLichLamViecNV.Location = new System.Drawing.Point(139, 505);
            this.btnCapNhatLichLamViecNV.Name = "btnCapNhatLichLamViecNV";
            this.btnCapNhatLichLamViecNV.Size = new System.Drawing.Size(219, 46);
            this.btnCapNhatLichLamViecNV.TabIndex = 2;
            this.btnCapNhatLichLamViecNV.Text = "Xem lịch làm việc";
            this.btnCapNhatLichLamViecNV.UseVisualStyleBackColor = false;
            this.btnCapNhatLichLamViecNV.Click += new System.EventHandler(this.BtnCapnhatlichlvnv_Click);
            // 
            // btnCapNhatThongTinNV
            // 
            this.btnCapNhatThongTinNV.BackColor = System.Drawing.Color.Honeydew;
            this.btnCapNhatThongTinNV.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatThongTinNV.ForeColor = System.Drawing.Color.BlueViolet;
            this.btnCapNhatThongTinNV.Location = new System.Drawing.Point(392, 505);
            this.btnCapNhatThongTinNV.Name = "btnCapNhatThongTinNV";
            this.btnCapNhatThongTinNV.Size = new System.Drawing.Size(219, 46);
            this.btnCapNhatThongTinNV.TabIndex = 0;
            this.btnCapNhatThongTinNV.Text = "Cập nhật thông tin nhân viên";
            this.btnCapNhatThongTinNV.UseVisualStyleBackColor = false;
            this.btnCapNhatThongTinNV.Click += new System.EventHandler(this.btnCapnhatthongtinnv_Click);
            // 
            // lblQuanLyNhanVien
            // 
            this.lblQuanLyNhanVien.AutoSize = true;
            this.lblQuanLyNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.lblQuanLyNhanVien.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanLyNhanVien.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblQuanLyNhanVien.Location = new System.Drawing.Point(15, 6);
            this.lblQuanLyNhanVien.Name = "lblQuanLyNhanVien";
            this.lblQuanLyNhanVien.Size = new System.Drawing.Size(325, 73);
            this.lblQuanLyNhanVien.TabIndex = 1;
            this.lblQuanLyNhanVien.Text = "QUẢN LÝ";
            this.lblQuanLyNhanVien.Click += new System.EventHandler(this.lblQuanLyNhanVien_Click);
            // 
            // pnlQLNV
            // 
            this.pnlQLNV.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlQLNV.Controls.Add(this.label3);
            this.pnlQLNV.Controls.Add(this.label2);
            this.pnlQLNV.Controls.Add(this.label1);
            this.pnlQLNV.Controls.Add(this.btnCapNhatLichLamViecNV);
            this.pnlQLNV.Controls.Add(this.btnCapNhatThongTinNV);
            this.pnlQLNV.Controls.Add(this.dgvLichLamViec);
            this.pnlQLNV.Controls.Add(this.lblQuanLyNhanVien);
            this.pnlQLNV.Location = new System.Drawing.Point(711, 46);
            this.pnlQLNV.Name = "pnlQLNV";
            this.pnlQLNV.Size = new System.Drawing.Size(701, 637);
            this.pnlQLNV.TabIndex = 3;
            this.pnlQLNV.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlQLNV_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(603, 596);
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
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(603, 563);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 33);
            this.label2.TabIndex = 18;
            this.label2.Text = "Royal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(15, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 73);
            this.label1.TabIndex = 3;
            this.label1.Text = "NHÂN VIÊN";
            // 
            // dgvLichLamViec
            // 
            this.dgvLichLamViec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichLamViec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichLamViec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.TenNV,
            this.CaTruc,
            this.Ngay,
            this.id});
            this.dgvLichLamViec.Location = new System.Drawing.Point(28, 166);
            this.dgvLichLamViec.Name = "dgvLichLamViec";
            this.dgvLichLamViec.ReadOnly = true;
            this.dgvLichLamViec.RowHeadersWidth = 51;
            this.dgvLichLamViec.RowTemplate.Height = 24;
            this.dgvLichLamViec.Size = new System.Drawing.Size(650, 322);
            this.dgvLichLamViec.TabIndex = 0;
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            // 
            // TenNV
            // 
            this.TenNV.HeaderText = "Tên Nhân Viên";
            this.TenNV.Name = "TenNV";
            this.TenNV.ReadOnly = true;
            // 
            // CaTruc
            // 
            this.CaTruc.HeaderText = "Ca Trực";
            this.CaTruc.Name = "CaTruc";
            this.CaTruc.ReadOnly = true;
            // 
            // Ngay
            // 
            this.Ngay.HeaderText = "Ngày";
            this.Ngay.Name = "Ngay";
            this.Ngay.ReadOnly = true;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.QLNV;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1450, 784);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmQuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1450, 780);
            this.ControlBox = false;
            this.Controls.Add(this.pnlQLNV);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanLyNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Màn hình quản lý nhân viên";
            this.Load += new System.EventHandler(this.frmQuanLyNhanVien_Load);
            this.pnlQLNV.ResumeLayout(false);
            this.pnlQLNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichLamViec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCapNhatThongTinNV;
        private System.Windows.Forms.Label lblQuanLyNhanVien;
        private System.Windows.Forms.Panel pnlQLNV;
        private System.Windows.Forms.DataGridView dgvLichLamViec;
        private System.Windows.Forms.Button btnCapNhatLichLamViecNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaTruc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}