namespace QuanLyQuanKaraoke.Forms
{
    partial class frmDanhSachPhong
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
            btnMoPhong = new Button();
            groupBox2 = new GroupBox();
            panelPhong = new FlowLayoutPanel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnMoPhong);
            groupBox1.Location = new Point(11, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1322, 126);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // btnMoPhong
            // 
            btnMoPhong.Location = new Point(1112, 52);
            btnMoPhong.Name = "btnMoPhong";
            btnMoPhong.Size = new Size(185, 46);
            btnMoPhong.TabIndex = 0;
            btnMoPhong.Text = "Mở phòng";
            btnMoPhong.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(panelPhong);
            groupBox2.Location = new Point(12, 149);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1321, 695);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách phòng";
            // 
            // panelPhong
            // 
            panelPhong.AutoScroll = true;
            panelPhong.Dock = DockStyle.Fill;
            panelPhong.Location = new Point(3, 40);
            panelPhong.Name = "panelPhong";
            panelPhong.Size = new Size(1315, 652);
            panelPhong.TabIndex = 0;
            // 
            // frmDanhSachPhong
            // 
            AutoScaleDimensions = new SizeF(19F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1345, 856);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmDanhSachPhong";
            Text = "Danh sách phòng";
            Load += frmDanhSachPhong_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Button btnMoPhong;
        private GroupBox groupBox2;
        private FlowLayoutPanel panelPhong;
    }
}