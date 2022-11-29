﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using PhanMemQuanLyKhachSan.Model;

namespace PhanMemQuanLyKhachSan
{
    public partial class frmQuanLyPhong : Form
    {
        // DUNG MODEL LOAI PHONG - PHONG 
        public frmQuanLyPhong()
        {
            InitializeComponent();
        }

        // design bang
        public void SetGridViewStyle(DataGridView dgview)
        {
            dgview.BorderStyle = BorderStyle.None;
            dgview.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgview.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgview.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgview.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgview.BackgroundColor = Color.White;
            dgview.EnableHeadersVisualStyles = false;
            dgview.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgview.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgview.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgview.AllowUserToDeleteRows = false;
            dgview.AllowUserToAddRows = false;
            dgview.AllowUserToOrderColumns = true;
            dgview.MultiSelect = false;
            dgview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void BindGrid(List<Phong> listPhong) // LAY DU LIEU TU CSDL
        {
            dgvQuanLyPhong.Rows.Clear();

            foreach (var item in listPhong)
            {
                int index = dgvQuanLyPhong.Rows.Add();
                dgvQuanLyPhong.Rows[index].Cells[0].Value = item.PhongID;
                dgvQuanLyPhong.Rows[index].Cells[1].Value = item.LoaiPhong.TenLoai;
                dgvQuanLyPhong.Rows[index].Cells[2].Value = item.GiaPhong;
            }
        }
        private void ButtonCapNhapLoaiPhong_Click(object sender, EventArgs e)
        {
            frmCapNhatLoaiPhong fmb = new frmCapNhatLoaiPhong();
            fmb.Show();
        }
        private void fmb_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        // cap nhat dich vu

        private void Button2_Click(object sender, EventArgs e)
        {
            frmCapNhatDichVu fmdv = new frmCapNhatDichVu();
            fmdv.Show();
        }
        private void fmdv_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        // cap nhat vat tu
        private void Button1_Click(object sender, EventArgs e)
        {
            frmCapNhatVatTu fmvt = new frmCapNhatVatTu();
            fmvt.Show();
        }
        private void fmvt_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }


        private void dgvQuanLyPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmQuanLyPhong_Load(object sender, EventArgs e)
        {
            try
            {
                SetGridViewStyle(dgvQuanLyPhong);
                BindGrid(Phong.GetAll());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblQuanLyNhanVien_Click(object sender, EventArgs e)
        {

        }
    }
}
