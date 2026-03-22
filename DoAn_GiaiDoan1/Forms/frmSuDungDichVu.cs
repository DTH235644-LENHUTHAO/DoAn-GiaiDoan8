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
    public partial class frmSuDungDichVu : Form
    {
        QLQKDbContext context = new QLQKDbContext(); // Khởi tạo biến ngữ cảnh CSDL
        int id; // Lấy mã hóa đơn (dùng cho Sửa và Xóa)
        BindingList<DanhSachSuDungDichVu> sudungDichVu = new BindingList<DanhSachSuDungDichVu>();
        public frmSuDungDichVu(int maSuDungDichVu)
        {
            InitializeComponent();
            id = maSuDungDichVu;
        }

        private void frmSuDungDichVu_Load(object sender, EventArgs e)
        {
            cboDichVu.DataSource = context.DichVu.ToList();
            cboDichVu.DisplayMember = "TenDV";
            cboDichVu.ValueMember = "ID";

            cboDichVu.SelectedIndexChanged += cboDichVu_SelectedIndexChanged;

            cboDichVu.SelectedIndex = -1;

            // Load danh sách đã dùng
            LoadDichVuDaDung();
        }

        private void cboDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDichVu.SelectedItem == null) return;

            var dv = cboDichVu.SelectedItem as DichVu;

            if (dv != null)
            {
                txtDonGia.Text = dv.DonGia.ToString("N0");
            }
        }

        void LoadDichVuDaDung()
        {
            List<DanhSachSuDungDichVu> p = new List<DanhSachSuDungDichVu>();
            p = context.SuDungDichVu.Select(r => new DanhSachSuDungDichVu
            {
                ID = r.ID,
                DatPhongID = r.DatPhongID,
                DichVuID = r.DichVuID,
                TenDV = r.DichVu.TenDV,
                SoLuong = r.SoLuong,
                DonGia = r.DichVu.DonGia
            }).ToList();
            BindingSource bs = new BindingSource();
            bs.DataSource = p;

            cboDichVu.DataBindings.Clear();
            cboDichVu.DataBindings.Add("SelectedValue", bs, "DichVuID", false, DataSourceUpdateMode.Never);

            txtDonGia.DataBindings.Clear();
            txtDonGia.DataBindings.Add("Text", bs, "DonGia", false, DataSourceUpdateMode.Never);

            numSoLuong.DataBindings.Clear();
            numSoLuong.DataBindings.Add("Value", bs, "SoLuong", false, DataSourceUpdateMode.Never);

            dataGridView1.DataSource = bs;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cboDichVu.SelectedIndex == -1)
            {
                MessageBox.Show("Chọn dịch vụ!");
                return;
            }

            int idDV = (int)cboDichVu.SelectedValue;
            int soLuong = (int)numSoLuong.Value;

            //kiểm tra tồn tại
            var dv = context.SuDungDichVu
                .FirstOrDefault(x => x.DatPhongID == id && x.DichVuID == idDV);

            if (dv != null)
            {
                dv.SoLuong += soLuong;
                context.SuDungDichVu.Update(dv);
            }
            else
            {
                SuDungDichVu s = new SuDungDichVu();
                s.DatPhongID = id;
                s.DichVuID = idDV;
                s.SoLuong = soLuong;

                context.SuDungDichVu.Add(s);
            }

            context.SaveChanges();

            LoadDichVuDaDung();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa dịch vụ?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
                SuDungDichVu sddv = context.SuDungDichVu.Find(id);
                if (sddv != null)
                {
                    context.SuDungDichVu.Remove(sddv);
                }
                context.SaveChanges();
                frmSuDungDichVu_Load(sender, e);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Chọn dòng cần sửa!");
                return;
            }

            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);

            var dv = context.SuDungDichVu.Find(id);

            if (dv != null)
            {
                dv.SoLuong = (int)numSoLuong.Value;

                context.SuDungDichVu.Update(dv);
                context.SaveChanges();

                LoadDichVuDaDung();
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            cboDichVu.SelectedValue = dataGridView1.CurrentRow.Cells["DichVuID"].Value;
            numSoLuong.Value = Convert.ToInt32(dataGridView1.CurrentRow.Cells["SoLuong"].Value);
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmSuDungDichVu_Load(sender, e);
        }
    }
}
