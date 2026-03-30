namespace QuanLyQuanKaraoke.Forms
{
    partial class frmMoPhong
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
            lblPhong = new Label();
            lblNhanVien = new Label();
            cbKhachHang = new ComboBox();
            label1 = new Label();
            btnMoPhong = new Button();
            SuspendLayout();
            // 
            // lblPhong
            // 
            lblPhong.AutoSize = true;
            lblPhong.Location = new Point(170, 83);
            lblPhong.Name = "lblPhong";
            lblPhong.Size = new Size(140, 31);
            lblPhong.TabIndex = 0;
            lblPhong.Text = "Tên Phòng";
            // 
            // lblNhanVien
            // 
            lblNhanVien.AutoSize = true;
            lblNhanVien.Location = new Point(499, 84);
            lblNhanVien.Name = "lblNhanVien";
            lblNhanVien.Size = new Size(190, 31);
            lblNhanVien.TabIndex = 1;
            lblNhanVien.Text = "Tên Nhân Viên";
            // 
            // cbKhachHang
            // 
            cbKhachHang.FormattingEnabled = true;
            cbKhachHang.Location = new Point(1126, 84);
            cbKhachHang.Name = "cbKhachHang";
            cbKhachHang.Size = new Size(297, 39);
            cbKhachHang.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(890, 87);
            label1.Name = "label1";
            label1.Size = new Size(164, 31);
            label1.TabIndex = 3;
            label1.Text = "Khách hàng:";
            // 
            // btnMoPhong
            // 
            btnMoPhong.Location = new Point(1535, 80);
            btnMoPhong.Name = "btnMoPhong";
            btnMoPhong.Size = new Size(184, 45);
            btnMoPhong.TabIndex = 4;
            btnMoPhong.Text = "Mở phòng";
            btnMoPhong.UseVisualStyleBackColor = true;
            btnMoPhong.Click += btnMoPhong_Click;
            // 
            // frmMoPhong
            // 
            AutoScaleDimensions = new SizeF(16F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1952, 228);
            Controls.Add(btnMoPhong);
            Controls.Add(label1);
            Controls.Add(cbKhachHang);
            Controls.Add(lblNhanVien);
            Controls.Add(lblPhong);
            Font = new Font("Times New Roman", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 163);
            Name = "frmMoPhong";
            Text = "Mở phòng";
            Load += frmDatPhong_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPhong;
        private Label lblNhanVien;
        private ComboBox cbKhachHang;
        private Label label1;
        private Button btnMoPhong;
    }
}