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
    public partial class Report2 : Form
    {
        public Report2()
        {
            InitializeComponent();
        }

        private void Report2_Load(object sender, EventArgs e)
        {
            HienThiThongKeKhachHang();
            //this.reportViewer1.RefreshReport();
        }
        private void HienThiThongKeKhachHang()
        {
            using (var _dbcontext = new QLKSModel())
            {
                string truyVanSQL = " select TenKH, QuocTich, SoDem, TenBooking from KhachHang, HoaDon, Booking where KhachHang.KhachHangID = HoaDon.KhachHangID AND HoaDon.BookingID = Booking.BookingID";
                List<ThongKeKhachHang> danhsach = _dbcontext.Database.SqlQuery<ThongKeKhachHang>(truyVanSQL).ToList();
                /*
                if (txbNhapTen.Text != "")
                {
                    danhsach = danhsach.Where(kh => kh.TenKH.ToLower() == txbNhapTen.Text.ToLower()).ToList();
                }
                */
                this.reportViewer1.LocalReport.ReportPath = "ReportKetQuaKhachHang.rdlc";
                var reportDataSource = new ReportDataSource("ThongKeKhachHangDataset", danhsach);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer1.RefreshReport();
                
            }
        }
    }
}
