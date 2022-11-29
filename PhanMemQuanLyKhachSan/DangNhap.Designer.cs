namespace PhanMemQuanLyKhachSan
{
    partial class frmDangNhap
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
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.pnlTenDangNhap = new System.Windows.Forms.Panel();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.pnlMatKhau = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHienMatKhau = new System.Windows.Forms.Button();
            this.picMatKhau = new System.Windows.Forms.PictureBox();
            this.picTenDangNhap = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMatKhau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTenDangNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTenDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenDangNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDangNhap.ForeColor = System.Drawing.Color.DimGray;
            this.txtTenDangNhap.Location = new System.Drawing.Point(92, 318);
            this.txtTenDangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(350, 23);
            this.txtTenDangNhap.TabIndex = 1;
            this.txtTenDangNhap.Text = "Tên đăng nhập";
            this.txtTenDangNhap.TextChanged += new System.EventHandler(this.txtTenDangNhap_TextChanged);
            this.txtTenDangNhap.Enter += new System.EventHandler(this.txtTendangnhap_Enter);
            this.txtTenDangNhap.Leave += new System.EventHandler(this.txtTendangnhap_Leave);
            // 
            // pnlTenDangNhap
            // 
            this.pnlTenDangNhap.BackColor = System.Drawing.Color.Orange;
            this.pnlTenDangNhap.ForeColor = System.Drawing.Color.Peru;
            this.pnlTenDangNhap.Location = new System.Drawing.Point(92, 345);
            this.pnlTenDangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.pnlTenDangNhap.Name = "pnlTenDangNhap";
            this.pnlTenDangNhap.Size = new System.Drawing.Size(350, 1);
            this.pnlTenDangNhap.TabIndex = 2;
            this.pnlTenDangNhap.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTenDangNhap_Paint);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BackColor = System.Drawing.Color.Black;
            this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatKhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.ForeColor = System.Drawing.Color.DimGray;
            this.txtMatKhau.Location = new System.Drawing.Point(92, 367);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(350, 23);
            this.txtMatKhau.TabIndex = 4;
            this.txtMatKhau.Text = "Mật khẩu";
            this.txtMatKhau.TextChanged += new System.EventHandler(this.txtMatKhau_TextChanged);
            this.txtMatKhau.Enter += new System.EventHandler(this.txtMatkhau_Enter);
            this.txtMatKhau.Leave += new System.EventHandler(this.txtMatkhau_Leave);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.Black;
            this.btnDangNhap.BackgroundImage = global::PhanMemQuanLyKhachSan.Properties.Resources.nền;
            this.btnDangNhap.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDangNhap.Location = new System.Drawing.Point(92, 485);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(129, 45);
            this.btnDangNhap.TabIndex = 8;
            this.btnDangNhap.Text = "Login";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.BtnDangNhap_Click);
            // 
            // btnDangKy
            // 
            this.btnDangKy.BackColor = System.Drawing.Color.Black;
            this.btnDangKy.BackgroundImage = global::PhanMemQuanLyKhachSan.Properties.Resources.nền;
            this.btnDangKy.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDangKy.Location = new System.Drawing.Point(285, 485);
            this.btnDangKy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(129, 45);
            this.btnDangKy.TabIndex = 11;
            this.btnDangKy.Text = "Sign in";
            this.btnDangKy.UseVisualStyleBackColor = false;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // pnlMatKhau
            // 
            this.pnlMatKhau.BackColor = System.Drawing.Color.Orange;
            this.pnlMatKhau.ForeColor = System.Drawing.Color.Peru;
            this.pnlMatKhau.Location = new System.Drawing.Point(92, 396);
            this.pnlMatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMatKhau.Name = "pnlMatKhau";
            this.pnlMatKhau.Size = new System.Drawing.Size(350, 1);
            this.pnlMatKhau.TabIndex = 12;
            this.pnlMatKhau.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMatKhau_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.background;
            this.pictureBox1.Location = new System.Drawing.Point(508, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(737, 648);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnHienMatKhau
            // 
            this.btnHienMatKhau.BackColor = System.Drawing.Color.Black;
            this.btnHienMatKhau.BackgroundImage = global::PhanMemQuanLyKhachSan.Properties.Resources.ShowIC;
            this.btnHienMatKhau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHienMatKhau.FlatAppearance.BorderSize = 0;
            this.btnHienMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHienMatKhau.Location = new System.Drawing.Point(414, 367);
            this.btnHienMatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHienMatKhau.Name = "btnHienMatKhau";
            this.btnHienMatKhau.Size = new System.Drawing.Size(28, 30);
            this.btnHienMatKhau.TabIndex = 7;
            this.btnHienMatKhau.UseVisualStyleBackColor = false;
            this.btnHienMatKhau.Click += new System.EventHandler(this.btnHienMatKhau_Click);
            this.btnHienMatKhau.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnHienmatkhau_MouseDown);
            this.btnHienMatKhau.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnHienmatkhau_MouseUp);
            // 
            // picMatKhau
            // 
            this.picMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.picMatKhau.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.white_lock_icon_png_16;
            this.picMatKhau.Location = new System.Drawing.Point(61, 367);
            this.picMatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picMatKhau.Name = "picMatKhau";
            this.picMatKhau.Size = new System.Drawing.Size(25, 30);
            this.picMatKhau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMatKhau.TabIndex = 6;
            this.picMatKhau.TabStop = false;
            this.picMatKhau.Click += new System.EventHandler(this.picMatKhau_Click);
            // 
            // picTenDangNhap
            // 
            this.picTenDangNhap.BackColor = System.Drawing.Color.Transparent;
            this.picTenDangNhap.BackgroundImage = global::PhanMemQuanLyKhachSan.Properties.Resources.nền;
            this.picTenDangNhap.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.Icon_User2;
            this.picTenDangNhap.Location = new System.Drawing.Point(61, 318);
            this.picTenDangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picTenDangNhap.Name = "picTenDangNhap";
            this.picTenDangNhap.Size = new System.Drawing.Size(25, 28);
            this.picTenDangNhap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTenDangNhap.TabIndex = 3;
            this.picTenDangNhap.TabStop = false;
            this.picTenDangNhap.Click += new System.EventHandler(this.picTenDangNhap_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.Black_and_white_minimalist_jewelry_logo__4_;
            this.pictureBox2.Location = new System.Drawing.Point(92, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(310, 269);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(332, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Forget Password ?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(181, 602);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Chưa có tài khoản ?";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PhanMemQuanLyKhachSan.Properties.Resources.nền;
            this.ClientSize = new System.Drawing.Size(1245, 641);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlMatKhau);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.btnHienMatKhau);
            this.Controls.Add(this.picMatKhau);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.picTenDangNhap);
            this.Controls.Add(this.pnlTenDangNhap);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMatKhau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTenDangNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Panel pnlTenDangNhap;
        private System.Windows.Forms.PictureBox picTenDangNhap;
        private System.Windows.Forms.PictureBox picMatKhau;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button btnHienMatKhau;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Panel pnlMatKhau;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

