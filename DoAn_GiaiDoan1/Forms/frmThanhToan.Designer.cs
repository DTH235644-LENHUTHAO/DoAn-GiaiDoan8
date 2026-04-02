namespace QuanLyQuanKaraoke.Forms
{
    partial class frmThanhToan
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
            qlqkDataSet1 = new QuanLyQuanKaraoke.Reports.QLQKDataSet();
            groupBox1 = new GroupBox();
            btnThoat = new Button();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            HoaDonID = new DataGridViewTextBoxColumn();
            SoTien = new DataGridViewTextBoxColumn();
            PhuongThuc = new DataGridViewTextBoxColumn();
            ThoiGianThanhToan = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)qlqkDataSet1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // qlqkDataSet1
            // 
            qlqkDataSet1.DataSetName = "QLQKDataSet";
            qlqkDataSet1.Namespace = "http://tempuri.org/QLQKDataSet.xsd";
            qlqkDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(12, 135);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1534, 552);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(1270, 59);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(150, 46);
            btnThoat.TabIndex = 1;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, HoaDonID, SoTien, PhuongThuc, ThoiGianThanhToan });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1528, 509);
            dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 10;
            ID.Name = "ID";
            // 
            // HoaDonID
            // 
            HoaDonID.DataPropertyName = "HoaDonID";
            HoaDonID.HeaderText = "ID hóa đơn";
            HoaDonID.MinimumWidth = 10;
            HoaDonID.Name = "HoaDonID";
            // 
            // SoTien
            // 
            SoTien.DataPropertyName = "SoTien";
            SoTien.HeaderText = "Số tiền";
            SoTien.MinimumWidth = 10;
            SoTien.Name = "SoTien";
            // 
            // PhuongThuc
            // 
            PhuongThuc.DataPropertyName = "PhuongThuc";
            PhuongThuc.HeaderText = "Phương thức";
            PhuongThuc.MinimumWidth = 10;
            PhuongThuc.Name = "PhuongThuc";
            // 
            // ThoiGianThanhToan
            // 
            ThoiGianThanhToan.DataPropertyName = "ThoiGianThanhToan";
            ThoiGianThanhToan.HeaderText = "Thời gian thanh toán";
            ThoiGianThanhToan.MinimumWidth = 10;
            ThoiGianThanhToan.Name = "ThoiGianThanhToan";
            // 
            // frmThanhToan
            // 
            AutoScaleDimensions = new SizeF(19F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1558, 699);
            Controls.Add(btnThoat);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmThanhToan";
            Text = "Thanh toán";
            Load += frmThanhToan_Load;
            ((System.ComponentModel.ISupportInitialize)qlqkDataSet1).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Reports.QLQKDataSet qlqkDataSet1;
        private GroupBox groupBox1;
        private Button btnThoat;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn HoaDonID;
        private DataGridViewTextBoxColumn SoTien;
        private DataGridViewTextBoxColumn PhuongThuc;
        private DataGridViewTextBoxColumn ThoiGianThanhToan;
    }
}