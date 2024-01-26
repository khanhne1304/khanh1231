namespace HocSinh
{
    partial class FMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnDanhSachHocSInh = new Button();
            btnDanhSachGiaoVien = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // btnDanhSachHocSInh
            // 
            btnDanhSachHocSInh.Location = new Point(12, 12);
            btnDanhSachHocSInh.Name = "btnDanhSachHocSInh";
            btnDanhSachHocSInh.Size = new Size(185, 33);
            btnDanhSachHocSInh.TabIndex = 0;
            btnDanhSachHocSInh.Text = "Danh sách học sinh";
            btnDanhSachHocSInh.UseVisualStyleBackColor = true;
            btnDanhSachHocSInh.Click += btnDanhSachHocSInh_Click;
            // 
            // btnDanhSachGiaoVien
            // 
            btnDanhSachGiaoVien.Location = new Point(221, 12);
            btnDanhSachGiaoVien.Name = "btnDanhSachGiaoVien";
            btnDanhSachGiaoVien.Size = new Size(185, 33);
            btnDanhSachGiaoVien.TabIndex = 1;
            btnDanhSachGiaoVien.Text = "Danh sách giáo viên";
            btnDanhSachGiaoVien.UseVisualStyleBackColor = true;
            btnDanhSachGiaoVien.Click += btnDanhSachGiaoVien_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(678, 392);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(93, 33);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // FMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnThoat);
            Controls.Add(btnDanhSachGiaoVien);
            Controls.Add(btnDanhSachHocSInh);
            Name = "FMain";
            Text = "Quản lý ";
            ResumeLayout(false);
        }

        #endregion

        private Button btnDanhSachHocSInh;
        private Button btnDanhSachGiaoVien;
        private Button btnThoat;
    }
}