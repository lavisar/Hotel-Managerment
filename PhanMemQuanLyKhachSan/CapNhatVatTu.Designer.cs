namespace PhanMemQuanLyKhachSan
{
    partial class frmCapNhatVatTu
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
            this.txtCapNhatVatTu = new System.Windows.Forms.TextBox();
            this.dgvCapNhatVatTu = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenVatTu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoaDichVuVT = new System.Windows.Forms.Button();
            this.btnThemDichVuVT = new System.Windows.Forms.Button();
            this.btnLuuCapNhatVatTu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapNhatVatTu)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCapNhatVatTu
            // 
            this.txtCapNhatVatTu.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCapNhatVatTu.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapNhatVatTu.Location = new System.Drawing.Point(318, 176);
            this.txtCapNhatVatTu.Multiline = true;
            this.txtCapNhatVatTu.Name = "txtCapNhatVatTu";
            this.txtCapNhatVatTu.Size = new System.Drawing.Size(337, 31);
            this.txtCapNhatVatTu.TabIndex = 15;
            // 
            // dgvCapNhatVatTu
            // 
            this.dgvCapNhatVatTu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCapNhatVatTu.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dgvCapNhatVatTu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCapNhatVatTu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.id,
            this.tenVatTu});
            this.dgvCapNhatVatTu.Location = new System.Drawing.Point(318, 222);
            this.dgvCapNhatVatTu.Name = "dgvCapNhatVatTu";
            this.dgvCapNhatVatTu.ReadOnly = true;
            this.dgvCapNhatVatTu.Size = new System.Drawing.Size(429, 257);
            this.dgvCapNhatVatTu.TabIndex = 14;
            this.dgvCapNhatVatTu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cell_Click);
            // 
            // stt
            // 
            this.stt.FillWeight = 25.38071F;
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.id.Visible = false;
            // 
            // tenVatTu
            // 
            this.tenVatTu.FillWeight = 174.6193F;
            this.tenVatTu.HeaderText = "Tên Vật Tư";
            this.tenVatTu.Name = "tenVatTu";
            this.tenVatTu.ReadOnly = true;
            // 
            // btnXoaDichVuVT
            // 
            this.btnXoaDichVuVT.BackColor = System.Drawing.Color.Pink;
            this.btnXoaDichVuVT.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaDichVuVT.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconDelete;
            this.btnXoaDichVuVT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaDichVuVT.Location = new System.Drawing.Point(318, 485);
            this.btnXoaDichVuVT.Name = "btnXoaDichVuVT";
            this.btnXoaDichVuVT.Size = new System.Drawing.Size(145, 35);
            this.btnXoaDichVuVT.TabIndex = 13;
            this.btnXoaDichVuVT.Text = "DELETE";
            this.btnXoaDichVuVT.UseVisualStyleBackColor = false;
            this.btnXoaDichVuVT.Click += new System.EventHandler(this.btnXoaDichVuVT_Click);
            // 
            // btnThemDichVuVT
            // 
            this.btnThemDichVuVT.BackColor = System.Drawing.Color.Pink;
            this.btnThemDichVuVT.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDichVuVT.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconThem;
            this.btnThemDichVuVT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemDichVuVT.Location = new System.Drawing.Point(661, 176);
            this.btnThemDichVuVT.Name = "btnThemDichVuVT";
            this.btnThemDichVuVT.Size = new System.Drawing.Size(86, 31);
            this.btnThemDichVuVT.TabIndex = 12;
            this.btnThemDichVuVT.Text = "ADD";
            this.btnThemDichVuVT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemDichVuVT.UseVisualStyleBackColor = false;
            this.btnThemDichVuVT.Click += new System.EventHandler(this.btnThemDichVuVT_Click);
            // 
            // btnLuuCapNhatVatTu
            // 
            this.btnLuuCapNhatVatTu.BackColor = System.Drawing.Color.Pink;
            this.btnLuuCapNhatVatTu.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuCapNhatVatTu.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconLuu;
            this.btnLuuCapNhatVatTu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuCapNhatVatTu.Location = new System.Drawing.Point(469, 485);
            this.btnLuuCapNhatVatTu.Name = "btnLuuCapNhatVatTu";
            this.btnLuuCapNhatVatTu.Size = new System.Drawing.Size(158, 35);
            this.btnLuuCapNhatVatTu.TabIndex = 11;
            this.btnLuuCapNhatVatTu.Text = "SAVE";
            this.btnLuuCapNhatVatTu.UseVisualStyleBackColor = false;
            this.btnLuuCapNhatVatTu.Click += new System.EventHandler(this.btnLuuCapNhatVatTu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(513, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 9;
            // 
            // frmCapNhatVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PhanMemQuanLyKhachSan.Properties.Resources.CNVT;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1051, 704);
            this.Controls.Add(this.btnThemDichVuVT);
            this.Controls.Add(this.btnXoaDichVuVT);
            this.Controls.Add(this.btnLuuCapNhatVatTu);
            this.Controls.Add(this.txtCapNhatVatTu);
            this.Controls.Add(this.dgvCapNhatVatTu);
            this.Controls.Add(this.label2);
            this.Name = "frmCapNhatVatTu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập Nhật Vật Tư";
            this.Load += new System.EventHandler(this.frmCapNhatVatTu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapNhatVatTu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCapNhatVatTu;
        private System.Windows.Forms.DataGridView dgvCapNhatVatTu;
        private System.Windows.Forms.Button btnXoaDichVuVT;
        private System.Windows.Forms.Button btnThemDichVuVT;
        private System.Windows.Forms.Button btnLuuCapNhatVatTu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenVatTu;
    }
}