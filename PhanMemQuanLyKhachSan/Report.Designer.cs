namespace PhanMemQuanLyKhachSan
{
    partial class Report
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
            this.lblNhapTen = new System.Windows.Forms.Label();
            this.txbNhapTen = new System.Windows.Forms.TextBox();
            this.bntXemBaoCao = new System.Windows.Forms.Button();
            this.rpvThongKeHoaDon = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // lblNhapTen
            // 
            this.lblNhapTen.AutoSize = true;
            this.lblNhapTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapTen.Location = new System.Drawing.Point(39, 50);
            this.lblNhapTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNhapTen.Name = "lblNhapTen";
            this.lblNhapTen.Size = new System.Drawing.Size(549, 52);
            this.lblNhapTen.TabIndex = 0;
            this.lblNhapTen.Text = "NHẬP TÊN KHÁCH HÀNG";
            // 
            // txbNhapTen
            // 
            this.txbNhapTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNhapTen.Location = new System.Drawing.Point(637, 50);
            this.txbNhapTen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbNhapTen.Name = "txbNhapTen";
            this.txbNhapTen.Size = new System.Drawing.Size(591, 41);
            this.txbNhapTen.TabIndex = 1;
            // 
            // bntXemBaoCao
            // 
            this.bntXemBaoCao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bntXemBaoCao.Location = new System.Drawing.Point(1295, 50);
            this.bntXemBaoCao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bntXemBaoCao.Name = "bntXemBaoCao";
            this.bntXemBaoCao.Size = new System.Drawing.Size(285, 43);
            this.bntXemBaoCao.TabIndex = 2;
            this.bntXemBaoCao.Text = "XEM BÁO CÁO";
            this.bntXemBaoCao.UseVisualStyleBackColor = false;
            this.bntXemBaoCao.Click += new System.EventHandler(this.bntXemBaoCao_Click);
            // 
            // rpvThongKeHoaDon
            // 
            this.rpvThongKeHoaDon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rpvThongKeHoaDon.Location = new System.Drawing.Point(0, 319);
            this.rpvThongKeHoaDon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rpvThongKeHoaDon.Name = "rpvThongKeHoaDon";
            this.rpvThongKeHoaDon.ServerReport.BearerToken = null;
            this.rpvThongKeHoaDon.Size = new System.Drawing.Size(1933, 641);
            this.rpvThongKeHoaDon.TabIndex = 3;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(1933, 960);
            this.Controls.Add(this.rpvThongKeHoaDon);
            this.Controls.Add(this.bntXemBaoCao);
            this.Controls.Add(this.txbNhapTen);
            this.Controls.Add(this.lblNhapTen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNhapTen;
        private System.Windows.Forms.TextBox txbNhapTen;
        private System.Windows.Forms.Button bntXemBaoCao;
        private Microsoft.Reporting.WinForms.ReportViewer rpvThongKeHoaDon;
    }
}