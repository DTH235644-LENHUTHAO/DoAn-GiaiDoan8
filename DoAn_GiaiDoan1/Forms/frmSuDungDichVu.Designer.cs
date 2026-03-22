namespace QuanLyQuanKaraoke.Forms
{
    partial class frmSuDungDichVu
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
            groupBox1 = new GroupBox();
            btnQuayLai = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            numSoLuong = new NumericUpDown();
            label3 = new Label();
            txtDonGia = new TextBox();
            label2 = new Label();
            label1 = new Label();
            cboDichVu = new ComboBox();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            DatPhongID = new DataGridViewTextBoxColumn();
            DichVuID = new DataGridViewTextBoxColumn();
            TenDV = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            btnHuyBo = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnQuayLai);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(numSoLuong);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtDonGia);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cboDichVu);
            groupBox1.Location = new Point(16, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1628, 254);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin dịch vụ";
            // 
            // btnQuayLai
            // 
            btnQuayLai.Location = new Point(1447, 112);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(150, 46);
            btnQuayLai.TabIndex = 10;
            btnQuayLai.Text = "Quay lại";
            btnQuayLai.UseVisualStyleBackColor = true;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(1231, 112);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(150, 46);
            btnSua.TabIndex = 9;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(1447, 43);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(150, 46);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(1231, 43);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(150, 46);
            btnThem.TabIndex = 7;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(1005, 73);
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(140, 44);
            numSoLuong.TabIndex = 5;
            numSoLuong.ThousandsSeparator = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(851, 78);
            label3.Name = "label3";
            label3.Size = new Size(148, 36);
            label3.TabIndex = 4;
            label3.Text = "Số lượng:";
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(606, 75);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(200, 44);
            txtDonGia.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(466, 79);
            label2.Name = "label2";
            label2.Size = new Size(134, 36);
            label2.TabIndex = 2;
            label2.Text = "Đơn giá:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 79);
            label1.Name = "label1";
            label1.Size = new Size(132, 36);
            label1.TabIndex = 1;
            label1.Text = "Dịch vụ:";
            // 
            // cboDichVu
            // 
            cboDichVu.FormattingEnabled = true;
            cboDichVu.Location = new Point(195, 76);
            cboDichVu.Name = "cboDichVu";
            cboDichVu.Size = new Size(242, 44);
            cboDichVu.TabIndex = 0;
            cboDichVu.SelectedIndexChanged += cboDichVu_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(14, 281);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1633, 562);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, DatPhongID, DichVuID, TenDV, SoLuong, DonGia });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 40);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1627, 519);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 10;
            ID.Name = "ID";
            // 
            // DatPhongID
            // 
            DatPhongID.DataPropertyName = "DatPhongID";
            DatPhongID.HeaderText = "Mã đặt phòng";
            DatPhongID.MinimumWidth = 10;
            DatPhongID.Name = "DatPhongID";
            // 
            // DichVuID
            // 
            DichVuID.DataPropertyName = "DichVuID";
            DichVuID.HeaderText = "Mã dịch vụ";
            DichVuID.MinimumWidth = 10;
            DichVuID.Name = "DichVuID";
            // 
            // TenDV
            // 
            TenDV.DataPropertyName = "TenDV";
            TenDV.HeaderText = "Tên dịch vụ";
            TenDV.MinimumWidth = 10;
            TenDV.Name = "TenDV";
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuong";
            SoLuong.HeaderText = "Số lượng";
            SoLuong.MinimumWidth = 10;
            SoLuong.Name = "SoLuong";
            // 
            // DonGia
            // 
            DonGia.DataPropertyName = "DonGia";
            DonGia.HeaderText = "Đơn giá";
            DonGia.MinimumWidth = 10;
            DonGia.Name = "DonGia";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(1337, 186);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(150, 46);
            btnHuyBo.TabIndex = 11;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // frmSuDungDichVu
            // 
            AutoScaleDimensions = new SizeF(19F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1659, 855);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmSuDungDichVu";
            Text = "Chọn dịch vụ";
            Load += frmSuDungDichVu_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label1;
        private ComboBox cboDichVu;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn DatPhongID;
        private DataGridViewTextBoxColumn DichVuID;
        private DataGridViewTextBoxColumn TenDV;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn DonGia;
        private NumericUpDown numSoLuong;
        private Label label3;
        private TextBox txtDonGia;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button btnThem;
        private Button btnQuayLai;
        private Button btnSua;
        private Button btnXoa;
        private Button btnHuyBo;
    }
}