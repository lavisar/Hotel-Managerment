using PhanMemQuanLyKhachSan.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PhanMemQuanLyKhachSan
{
    //DUNG MODEL MATKHAU
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();          
        }

        private void txtTendangnhap_Enter(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "Tên đăng nhập")
            {
                txtTenDangNhap.Text = "";
                txtTenDangNhap.ForeColor = Color.Coral;
            }
        }

        private void txtTendangnhap_Leave(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "")
            {
                txtTenDangNhap.Text = "Tên đăng nhập";
                txtTenDangNhap.ForeColor = Color.Silver;
            }
        }

        private void txtMatkhau_Enter(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "Mật khẩu")
            {
                txtMatKhau.UseSystemPasswordChar = true;
                txtMatKhau.Text = "";
                txtMatKhau.ForeColor = Color.Coral;
            }
        }

        private void txtMatkhau_Leave(object sender, EventArgs e)
        {
            
            if (txtMatKhau.Text == "")
            {
                txtMatKhau.UseSystemPasswordChar = false;
                txtMatKhau.Text = "Mật khẩu";
                txtMatKhau.ForeColor = Color.Silver;
            }
        }
        // -----------------------------------------------------------------------------------
        //XỬ LÍ EVENTS
        // khi click chuột
        private void btnHienmatkhau_MouseDown(object sender, MouseEventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = false;
        }
        // khi thả chuột
        private void btnHienmatkhau_MouseUp(object sender, MouseEventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = true;
        }

        // Event Đăng nhập
        private void BtnDangNhap_Click(object sender, EventArgs e)
        {
            //gọi đến class MatKhau
            MatKhau obj = new MatKhau();
            List<MatKhau> list = obj.GetAll();
            
            string tenDangNhap = txtTenDangNhap.Text;
            string matKhau = txtMatKhau.Text;
            var check = list.Where(item => item.username.Equals(tenDangNhap)).ToList();   // Tìm trong List ktra có tk không      
            if(check.Count > 0)
            {
                if(check[0].password.Equals(matKhau))
               {
                 MessageBox.Show("Đăng nhập thành công!");
                 Menu mhc = new Menu();
                 mhc.Show();
                 this.Hide();
                }
                else
                {
                    MessageBox.Show("Mật khẩu không đúng!");
                }
            }
            else
            {
                MessageBox.Show("Không tồn tại tài khoản trên hệ thống!");
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
//<<<<<<< HEAD
            MessageBox.Show("Đăng ký ADMIN nhé!");
//=======
            MessageBox.Show("Chức năng hiện chưa có, trở lại sau bạn nhé!");
//>>>>>>> 7afceaeaa667e1cc7033622aa8a0c5b29f6e55f2
        }

        private void btnQuenMatKhau_Click(object sender, EventArgs e)
        {
           
        }

        private void btnHienMatKhau_Click(object sender, EventArgs e)
        {

        }

        private void lblChuaCoTaiKhoan_Click(object sender, EventArgs e)
        {

        }

        private void pnlMatKhau_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picMatKhau_Click(object sender, EventArgs e)
        {

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void picTenDangNhap_Click(object sender, EventArgs e)
        {

        }

        private void pnlTenDangNhap_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Quên thì đi hỏi ADMIN nhé!");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
