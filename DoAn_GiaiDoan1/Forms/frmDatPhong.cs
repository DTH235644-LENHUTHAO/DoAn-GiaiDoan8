using QuanLyQuanKaraoke.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanKaraoke.Forms
{
    public partial class frmDatPhong : Form
    {
        public frmDatPhong()
        {
            InitializeComponent();
        }
        QLQKDbContext context = new QLQKDbContext();
        int id;

        private void frmDatPhong_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            List<DanhSachDatPhong> dp = new List<DanhSachDatPhong>();
            dp = context.DatPhong.Select(r => new DanhSachDatPhong
            {
                ID = r.ID,
                PhongID = r.PhongID,
                TenPhong = r.Phong.TenPhong,
                KhachHangID = r.KhachHangID,
                TenKhachHang = r.KhachHang.TenKH,
                NhanVienID = r.NhanVienID,
                TenNhanVien = r.NhanVien.TenNV,
                ThoiGianBatDau= r.ThoiGianBatDau,
                ThoiGianKetThuc = r.ThoiGianKetThuc
            }).ToList();
            dataGridView1.DataSource = dp;
        }
    }
}
