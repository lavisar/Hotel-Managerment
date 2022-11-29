using Microsoft.Reporting.WinForms;
using PhanMemQuanLyKhachSan.Model;
using PhanMemQuanLyKhachSan.Reportings;
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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            HienThiThongKeHoaDon();
            //this.rpvThongKeHoaDon.RefreshReport();
        }

        private void HienThiThongKeHoaDon()
        {
            using (var _dbcontext = new QLKSModel())
            {
                string truyVanSQL = "Select TenNV, TenKH, HoaDon.PhongID, SoDem, SoKhach, NgayHD, TongTien From NhanVien, KhachHang, Phong, HoaDon Where NhanVien.NhanVienID = HoaDon.NhanVienID AND KhachHang.KhachHangID=HoaDon.KhachHangID AND Phong.PhongID=HoaDon.PhongID ";
                List<ThongKeHoaDon> danhsach = _dbcontext.Database.SqlQuery<ThongKeHoaDon>(truyVanSQL).ToList();

                if(txbNhapTen.Text != "")
                {
                    danhsach=danhsach.Where(kh=>kh.TenKH.ToLower() == txbNhapTen.Text.ToLower()).ToList();
                }
                this.rpvThongKeHoaDon.LocalReport.ReportPath = "ReportKetQuaHoaDon.rdlc";
                var reportDataSource = new ReportDataSource("ThongKeHoaDonDataset",danhsach);
                this.rpvThongKeHoaDon.LocalReport.DataSources.Clear();
                this.rpvThongKeHoaDon.LocalReport.DataSources.Add(reportDataSource);
                this.rpvThongKeHoaDon.RefreshReport();

            }
        }

        private void bntXemBaoCao_Click(object sender, EventArgs e)
        {
            HienThiThongKeHoaDon();
        }
    }
}
