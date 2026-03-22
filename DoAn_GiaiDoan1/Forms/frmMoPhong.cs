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
    public partial class frmMoPhong : Form
    {
        QLQKDbContext context = new QLQKDbContext();
        int phongID;
        int nhanVienID;
        public frmMoPhong(int phongID, int nhanVienID)
        {
            InitializeComponent();
            this.phongID = phongID;
            this.nhanVienID = nhanVienID;
        }

        private void frmDatPhong_Load(object sender, EventArgs e)
        {
            lblPhong.Text = context.Phong.Find(phongID).TenPhong;
            lblNhanVien.Text = context.NhanVien.Find(nhanVienID).TenNV;

            cbKhachHang.DataSource = context.KhachHang.ToList();
            cbKhachHang.DisplayMember = "TenKH";
            cbKhachHang.ValueMember = "ID";
        }

        private void btnMoPhong_Click(object sender, EventArgs e)
        {
            DatPhong dp = new DatPhong();

            dp.PhongID = phongID;
            dp.NhanVienID = nhanVienID;
            dp.KhachHangID = Convert.ToInt32(cbKhachHang.SelectedValue);
            dp.ThoiGianBatDau = DateTime.Now;

            context.DatPhong.Add(dp);
            context.SaveChanges();

            MessageBox.Show("Mở phòng thành công!");

            this.Close();
        }
    }
}
