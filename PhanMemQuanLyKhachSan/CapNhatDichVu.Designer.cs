namespace PhanMemQuanLyKhachSan
{
    partial class frmCapNhatDichVu
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnLuuCapNhatDichVu = new System.Windows.Forms.Button();
            this.btnThemDichVu = new System.Windows.Forms.Button();
            this.btnXoaDichVu = new System.Windows.Forms.Button();
            this.dgvCapNhatDichVu = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCapNhatDichVu = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapNhatDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(442, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // btnLuuCapNhatDichVu
            // 
            this.btnLuuCapNhatDichVu.BackColor = System.Drawing.Color.Honeydew;
            this.btnLuuCapNhatDichVu.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuCapNhatDichVu.ForeColor = System.Drawing.Color.IndianRed;
            this.btnLuuCapNhatDichVu.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconLuu;
            this.btnLuuCapNhatDichVu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuCapNhatDichVu.Location = new System.Drawing.Point(828, 383);
            this.btnLuuCapNhatDichVu.Name = "btnLuuCapNhatDichVu";
            this.btnLuuCapNhatDichVu.Size = new System.Drawing.Size(132, 37);
            this.btnLuuCapNhatDichVu.TabIndex = 3;
            this.btnLuuCapNhatDichVu.Text = "SAVE";
            this.btnLuuCapNhatDichVu.UseVisualStyleBackColor = false;
            this.btnLuuCapNhatDichVu.Click += new System.EventHandler(this.btnLuuCapNhatDichVu_Click);
            // 
            // btnThemDichVu
            // 
            this.btnThemDichVu.BackColor = System.Drawing.Color.Honeydew;
            this.btnThemDichVu.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDichVu.ForeColor = System.Drawing.Color.IndianRed;
            this.btnThemDichVu.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconThem;
            this.btnThemDichVu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemDichVu.Location = new System.Drawing.Point(529, 383);
            this.btnThemDichVu.Name = "btnThemDichVu";
            this.btnThemDichVu.Size = new System.Drawing.Size(132, 37);
            this.btnThemDichVu.TabIndex = 4;
            this.btnThemDichVu.Text = "ADD";
            this.btnThemDichVu.UseVisualStyleBackColor = false;
            this.btnThemDichVu.Click += new System.EventHandler(this.btnThemDichVu_Click);
            // 
            // btnXoaDichVu
            // 
            this.btnXoaDichVu.BackColor = System.Drawing.Color.Honeydew;
            this.btnXoaDichVu.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaDichVu.ForeColor = System.Drawing.Color.IndianRed;
            this.btnXoaDichVu.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconDelete;
            this.btnXoaDichVu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaDichVu.Location = new System.Drawing.Point(679, 383);
            this.btnXoaDichVu.Name = "btnXoaDichVu";
            this.btnXoaDichVu.Size = new System.Drawing.Size(132, 37);
            this.btnXoaDichVu.TabIndex = 5;
            this.btnXoaDichVu.Text = "DELETE";
            this.btnXoaDichVu.UseVisualStyleBackColor = false;
            this.btnXoaDichVu.Click += new System.EventHandler(this.btnXoaDichVu_Click);
            // 
            // dgvCapNhatDichVu
            // 
            this.dgvCapNhatDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCapNhatDichVu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvCapNhatDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCapNhatDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.id,
            this.TenDichVu,
            this.Gia});
            this.dgvCapNhatDichVu.Location = new System.Drawing.Point(27, 279);
            this.dgvCapNhatDichVu.Name = "dgvCapNhatDichVu";
            this.dgvCapNhatDichVu.ReadOnly = true;
            this.dgvCapNhatDichVu.Size = new System.Drawing.Size(478, 346);
            this.dgvCapNhatDichVu.TabIndex = 6;
            this.dgvCapNhatDichVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cell_Click);
            // 
            // stt
            // 
            this.stt.FillWeight = 38.07107F;
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // TenDichVu
            // 
            this.TenDichVu.FillWeight = 130.9645F;
            this.TenDichVu.HeaderText = "Tên Dịch Vụ";
            this.TenDichVu.Name = "TenDichVu";
            this.TenDichVu.ReadOnly = true;
            // 
            // Gia
            // 
            this.Gia.FillWeight = 130.9645F;
            this.Gia.HeaderText = "Giá Dịch Vụ";
            this.Gia.Name = "Gia";
            this.Gia.ReadOnly = true;
            // 
            // txtCapNhatDichVu
            // 
            this.txtCapNhatDichVu.BackColor = System.Drawing.Color.MediumAquamarine;
            this.txtCapNhatDichVu.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapNhatDichVu.Location = new System.Drawing.Point(529, 279);
            this.txtCapNhatDichVu.Multiline = true;
            this.txtCapNhatDichVu.Name = "txtCapNhatDichVu";
            this.txtCapNhatDichVu.Size = new System.Drawing.Size(431, 29);
            this.txtCapNhatDichVu.TabIndex = 7;
            this.txtCapNhatDichVu.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // txtGia
            // 
            this.txtGia.BackColor = System.Drawing.Color.MediumAquamarine;
            this.txtGia.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Location = new System.Drawing.Point(529, 324);
            this.txtGia.Multiline = true;
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(430, 29);
            this.txtGia.TabIndex = 7;
            this.txtGia.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(814, 257);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 117);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // frmCapNhatDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PhanMemQuanLyKhachSan.Properties.Resources.nenCNDV;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(989, 676);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtCapNhatDichVu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvCapNhatDichVu);
            this.Controls.Add(this.btnXoaDichVu);
            this.Controls.Add(this.btnThemDichVu);
            this.Controls.Add(this.btnLuuCapNhatDichVu);
            this.Controls.Add(this.label2);
            this.Name = "frmCapNhatDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập Nhật Dịch Vụ";
            this.Load += new System.EventHandler(this.frmCapNhatDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapNhatDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLuuCapNhatDichVu;
        private System.Windows.Forms.Button btnThemDichVu;
        private System.Windows.Forms.Button btnXoaDichVu;
        private System.Windows.Forms.DataGridView dgvCapNhatDichVu;
        private System.Windows.Forms.TextBox txtCapNhatDichVu;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}