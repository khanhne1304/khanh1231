namespace HocSinh.Forms
{
    partial class FGiaoVien
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
            btnThoat = new Button();
            dtpNgaySinh = new DateTimePicker();
            dgvGiaoVien = new DataGridView();
            txtDiaChi = new TextBox();
            txtCMND = new TextBox();
            txtHoTen = new TextBox();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            lblCMND = new Label();
            lblNgaySinh = new Label();
            lblHoTen = new Label();
            lblDiaChi = new Label();
            lblThongTin = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvGiaoVien).BeginInit();
            SuspendLayout();
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnThoat.Location = new Point(465, 518);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 27;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Location = new Point(252, 200);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(307, 27);
            dtpNgaySinh.TabIndex = 26;
            // 
            // dgvGiaoVien
            // 
            dgvGiaoVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGiaoVien.BackgroundColor = SystemColors.Control;
            dgvGiaoVien.BorderStyle = BorderStyle.Fixed3D;
            dgvGiaoVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGiaoVien.Location = new Point(638, 78);
            dgvGiaoVien.MultiSelect = false;
            dgvGiaoVien.Name = "dgvGiaoVien";
            dgvGiaoVien.ReadOnly = true;
            dgvGiaoVien.RowHeadersWidth = 51;
            dgvGiaoVien.RowTemplate.Height = 29;
            dgvGiaoVien.Size = new Size(783, 469);
            dgvGiaoVien.TabIndex = 25;
            dgvGiaoVien.CellClick += dgvGiaoVien_CellClick;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDiaChi.Location = new Point(252, 158);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(307, 30);
            txtDiaChi.TabIndex = 24;
            // 
            // txtCMND
            // 
            txtCMND.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCMND.Location = new Point(252, 117);
            txtCMND.Name = "txtCMND";
            txtCMND.Size = new Size(307, 30);
            txtCMND.TabIndex = 23;
            // 
            // txtHoTen
            // 
            txtHoTen.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtHoTen.Location = new Point(252, 75);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(307, 30);
            txtHoTen.TabIndex = 22;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoa.Location = new Point(326, 518);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 21;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSua.Location = new Point(196, 518);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 20;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnThem.Location = new Point(60, 518);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 19;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // lblCMND
            // 
            lblCMND.AutoSize = true;
            lblCMND.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCMND.Location = new Point(60, 117);
            lblCMND.Name = "lblCMND";
            lblCMND.Size = new Size(68, 22);
            lblCMND.TabIndex = 18;
            lblCMND.Text = "CMND";
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNgaySinh.Location = new Point(60, 200);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(88, 22);
            lblNgaySinh.TabIndex = 17;
            lblNgaySinh.Text = "Ngày sinh";
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblHoTen.Location = new Point(60, 78);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(86, 22);
            lblHoTen.TabIndex = 16;
            lblHoTen.Text = "Họ và tên";
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDiaChi.Location = new Point(60, 158);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(68, 22);
            lblDiaChi.TabIndex = 15;
            lblDiaChi.Text = "Địa chỉ";
            // 
            // lblThongTin
            // 
            lblThongTin.AutoSize = true;
            lblThongTin.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblThongTin.Location = new Point(60, 43);
            lblThongTin.Name = "lblThongTin";
            lblThongTin.Size = new Size(173, 22);
            lblThongTin.TabIndex = 14;
            lblThongTin.Text = "Thông tin giáo viên: ";
            // 
            // FGiaoVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 568);
            Controls.Add(btnThoat);
            Controls.Add(dtpNgaySinh);
            Controls.Add(dgvGiaoVien);
            Controls.Add(txtDiaChi);
            Controls.Add(txtCMND);
            Controls.Add(txtHoTen);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(lblCMND);
            Controls.Add(lblNgaySinh);
            Controls.Add(lblHoTen);
            Controls.Add(lblDiaChi);
            Controls.Add(lblThongTin);
            Name = "FGiaoVien";
            Text = "FGiaoVien";
            Load += FGiaoVien_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGiaoVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnThoat;
        private DateTimePicker dtpNgaySinh;
        private DataGridView dgvGiaoVien;
        private TextBox txtDiaChi;
        private TextBox txtCMND;
        private TextBox txtHoTen;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Label lblCMND;
        private Label lblNgaySinh;
        private Label lblHoTen;
        private Label lblDiaChi;
        private Label lblThongTin;
    }
}