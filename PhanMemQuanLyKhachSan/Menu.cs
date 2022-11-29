using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PhanMemQuanLyKhachSan
{
    public partial class Menu : Form
    {

        public Menu()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e) // Home
        {
            openChildForm(new ActiveForm());
        }
        private void bntDatPhong_Click(object sender, EventArgs e)
        {
            openChildForm(new frmManHinhChinh());
        }

        private void bntQLPhong_Click(object sender, EventArgs e)
        {
            openChildForm(new frmQuanLyPhong());
        }

        private void bntQLNV_Click(object sender, EventArgs e)
        {
            openChildForm(new frmQuanLyNhanVien());
        }

        private void bntQLKH_Click(object sender, EventArgs e)
        {
            openChildForm(new frmQuanLyKhachHang());
        }

        private void bntThongKe_Click(object sender, EventArgs e)
        {
            openChildForm(new frmThongKe());
        }

        private void bntLienHe_Click(object sender, EventArgs e)
        {
            openChildForm(new frmLienHe());
        }

        private void bntThoat_Click(object sender, EventArgs e)
        {
            frmDangNhap fmmhc = new frmDangNhap();
            fmmhc.Show();
            this.Hide();
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle= FormBorderStyle.None;
            childForm.Dock= DockStyle.Fill;
            pnl2.Controls.Add(childForm);
            pnl2.Tag = childForm;
            pnl2.Visible = true;
            childForm.BringToFront();
            childForm.Show();
        }

        
    }
}
