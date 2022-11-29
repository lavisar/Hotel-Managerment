namespace PhanMemQuanLyKhachSan
{
    partial class frmCapNhatLichLamViec
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
            this.lblLichLamViec = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.btnSuaLichLamViec = new System.Windows.Forms.Button();
            this.btnXoaLichLamViec = new System.Windows.Forms.Button();
            this.btnThemLichLamViec = new System.Windows.Forms.Button();
            this.dgvCapNhatLichLamViec = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnXemLai = new System.Windows.Forms.Button();
            this.cbxCa = new System.Windows.Forms.ComboBox();
            this.dtpNgayLamViec = new System.Windows.Forms.DateTimePicker();
            this.cbxTenNV = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapNhatLichLamViec)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLichLamViec
            // 
            this.lblLichLamViec.AutoSize = true;
            this.lblLichLamViec.BackColor = System.Drawing.Color.Transparent;
            this.lblLichLamViec.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLichLamViec.Location = new System.Drawing.Point(423, 110);
            this.lblLichLamViec.Name = "lblLichLamViec";
            this.lblLichLamViec.Size = new System.Drawing.Size(524, 44);
            this.lblLichLamViec.TabIndex = 0;
            this.lblLichLamViec.Text = "Lịch Làm Việc Toàn Bộ Nhân Viên";
            this.lblLichLamViec.Click += new System.EventHandler(this.LblLichLamViec_Click);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(1458, 255);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(244, 292);
            this.txtGhiChu.TabIndex = 14;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGhiChu.Location = new System.Drawing.Point(1545, 221);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(68, 22);
            this.lblGhiChu.TabIndex = 15;
            this.lblGhiChu.Text = "Ghi Chú";
            // 
            // btnSuaLichLamViec
            // 
            this.btnSuaLichLamViec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSuaLichLamViec.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaLichLamViec.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconSuaaaaa;
            this.btnSuaLichLamViec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaLichLamViec.Location = new System.Drawing.Point(410, 595);
            this.btnSuaLichLamViec.Name = "btnSuaLichLamViec";
            this.btnSuaLichLamViec.Size = new System.Drawing.Size(119, 35);
            this.btnSuaLichLamViec.TabIndex = 13;
            this.btnSuaLichLamViec.Text = "FIX";
            this.btnSuaLichLamViec.UseVisualStyleBackColor = false;
            this.btnSuaLichLamViec.Click += new System.EventHandler(this.btnSuaLichLamViec_Click);
            // 
            // btnXoaLichLamViec
            // 
            this.btnXoaLichLamViec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnXoaLichLamViec.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaLichLamViec.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconDelete;
            this.btnXoaLichLamViec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaLichLamViec.Location = new System.Drawing.Point(273, 595);
            this.btnXoaLichLamViec.Name = "btnXoaLichLamViec";
            this.btnXoaLichLamViec.Size = new System.Drawing.Size(116, 35);
            this.btnXoaLichLamViec.TabIndex = 12;
            this.btnXoaLichLamViec.Text = "DELETE";
            this.btnXoaLichLamViec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaLichLamViec.UseVisualStyleBackColor = false;
            this.btnXoaLichLamViec.Click += new System.EventHandler(this.btnXoaLichLamViec_Click);
            // 
            // btnThemLichLamViec
            // 
            this.btnThemLichLamViec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThemLichLamViec.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemLichLamViec.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconThem;
            this.btnThemLichLamViec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemLichLamViec.Location = new System.Drawing.Point(994, 395);
            this.btnThemLichLamViec.Name = "btnThemLichLamViec";
            this.btnThemLichLamViec.Size = new System.Drawing.Size(93, 37);
            this.btnThemLichLamViec.TabIndex = 11;
            this.btnThemLichLamViec.Text = "ADD";
            this.btnThemLichLamViec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemLichLamViec.UseVisualStyleBackColor = false;
            this.btnThemLichLamViec.Click += new System.EventHandler(this.btnThemLichLamViec_Click);
            // 
            // dgvCapNhatLichLamViec
            // 
            this.dgvCapNhatLichLamViec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCapNhatLichLamViec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCapNhatLichLamViec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.tenNV,
            this.ca,
            this.ngay,
            this.id});
            this.dgvCapNhatLichLamViec.Location = new System.Drawing.Point(273, 244);
            this.dgvCapNhatLichLamViec.Name = "dgvCapNhatLichLamViec";
            this.dgvCapNhatLichLamViec.Size = new System.Drawing.Size(569, 330);
            this.dgvCapNhatLichLamViec.TabIndex = 16;
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            // 
            // tenNV
            // 
            this.tenNV.HeaderText = "Tên Nhân Viên";
            this.tenNV.Name = "tenNV";
            // 
            // ca
            // 
            this.ca.HeaderText = "Ca";
            this.ca.Name = "ca";
            // 
            // ngay
            // 
            this.ngay.HeaderText = "Ngày Làm Việc";
            this.ngay.Name = "ngay";
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(273, 193);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(569, 31);
            this.textBox1.TabIndex = 17;
            // 
            // btnXemLai
            // 
            this.btnXemLai.BackColor = System.Drawing.Color.FloralWhite;
            this.btnXemLai.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemLai.Location = new System.Drawing.Point(767, 192);
            this.btnXemLai.Name = "btnXemLai";
            this.btnXemLai.Size = new System.Drawing.Size(75, 32);
            this.btnXemLai.TabIndex = 18;
            this.btnXemLai.Text = "REVIEW";
            this.btnXemLai.UseVisualStyleBackColor = false;
            // 
            // cbxCa
            // 
            this.cbxCa.FormattingEnabled = true;
            this.cbxCa.Location = new System.Drawing.Point(864, 325);
            this.cbxCa.Name = "cbxCa";
            this.cbxCa.Size = new System.Drawing.Size(223, 21);
            this.cbxCa.TabIndex = 21;
            // 
            // dtpNgayLamViec
            // 
            this.dtpNgayLamViec.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayLamViec.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayLamViec.Location = new System.Drawing.Point(864, 369);
            this.dtpNgayLamViec.Name = "dtpNgayLamViec";
            this.dtpNgayLamViec.Size = new System.Drawing.Size(223, 20);
            this.dtpNgayLamViec.TabIndex = 22;
            // 
            // cbxTenNV
            // 
            this.cbxTenNV.FormattingEnabled = true;
            this.cbxTenNV.Location = new System.Drawing.Point(864, 279);
            this.cbxTenNV.Name = "cbxTenNV";
            this.cbxTenNV.Size = new System.Drawing.Size(223, 21);
            this.cbxTenNV.TabIndex = 23;
            // 
            // frmCapNhatLichLamViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PhanMemQuanLyKhachSan.Properties.Resources.nenCNNV;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1133, 681);
            this.Controls.Add(this.cbxTenNV);
            this.Controls.Add(this.dtpNgayLamViec);
            this.Controls.Add(this.cbxCa);
            this.Controls.Add(this.btnXemLai);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgvCapNhatLichLamViec);
            this.Controls.Add(this.lblGhiChu);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.btnSuaLichLamViec);
            this.Controls.Add(this.btnXoaLichLamViec);
            this.Controls.Add(this.btnThemLichLamViec);
            this.Controls.Add(this.lblLichLamViec);
            this.Name = "frmCapNhatLichLamViec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhât lịch làm việc";
            this.Load += new System.EventHandler(this.frmCapNhatLichLamViec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapNhatLichLamViec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLichLamViec;
        private System.Windows.Forms.Button btnThemLichLamViec;
        private System.Windows.Forms.Button btnSuaLichLamViec;
        private System.Windows.Forms.Button btnXoaLichLamViec;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.DataGridView dgvCapNhatLichLamViec;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnXemLai;
        private System.Windows.Forms.ComboBox cbxCa;
        private System.Windows.Forms.DateTimePicker dtpNgayLamViec;
        private System.Windows.Forms.ComboBox cbxTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ca;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
    }
}