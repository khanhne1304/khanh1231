namespace HocSinh.Forms
{
    partial class FHocSinh
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
            lblThongTin = new Label();
            lblDiaChi = new Label();
            lblHoTen = new Label();
            lblNgaySinh = new Label();
            lblCMND = new Label();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            txtHoTen = new TextBox();
            txtCMND = new TextBox();
            txtDiaChi = new TextBox();
            dgvHocSinh = new DataGridView();
            dtpNgaySinh = new DateTimePicker();
            btnThoat = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvHocSinh).BeginInit();
            SuspendLayout();
            // 
            // lblThongTin
            // 
            lblThongTin.AutoSize = true;
            lblThongTin.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblThongTin.Location = new Point(55, 26);
            lblThongTin.Name = "lblThongTin";
            lblThongTin.Size = new Size(165, 22);
            lblThongTin.TabIndex = 0;
            lblThongTin.Text = "Thông tin học sinh: ";
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDiaChi.Location = new Point(55, 141);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(68, 22);
            lblDiaChi.TabIndex = 1;
            lblDiaChi.Text = "Địa chỉ";
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblHoTen.Location = new Point(55, 61);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(86, 22);
            lblHoTen.TabIndex = 2;
            lblHoTen.Text = "Họ và tên";
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNgaySinh.Location = new Point(55, 183);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(88, 22);
            lblNgaySinh.TabIndex = 3;
            lblNgaySinh.Text = "Ngày sinh";
            // 
            // lblCMND
            // 
            lblCMND.AutoSize = true;
            lblCMND.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCMND.Location = new Point(55, 100);
            lblCMND.Name = "lblCMND";
            lblCMND.Size = new Size(68, 22);
            lblCMND.TabIndex = 4;
            lblCMND.Text = "CMND";
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnThem.Location = new Point(55, 501);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 5;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSua.Location = new Point(191, 501);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 6;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoa.Location = new Point(321, 501);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // txtHoTen
            // 
            txtHoTen.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtHoTen.Location = new Point(247, 58);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(307, 30);
            txtHoTen.TabIndex = 8;
            // 
            // txtCMND
            // 
            txtCMND.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCMND.Location = new Point(247, 100);
            txtCMND.Name = "txtCMND";
            txtCMND.Size = new Size(307, 30);
            txtCMND.TabIndex = 9;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDiaChi.Location = new Point(247, 141);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(307, 30);
            txtDiaChi.TabIndex = 10;
            // 
            // dgvHocSinh
            // 
            dgvHocSinh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHocSinh.BackgroundColor = SystemColors.Control;
            dgvHocSinh.BorderStyle = BorderStyle.Fixed3D;
            dgvHocSinh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHocSinh.Location = new Point(633, 61);
            dgvHocSinh.MultiSelect = false;
            dgvHocSinh.Name = "dgvHocSinh";
            dgvHocSinh.ReadOnly = true;
            dgvHocSinh.RowHeadersWidth = 51;
            dgvHocSinh.RowTemplate.Height = 29;
            dgvHocSinh.Size = new Size(783, 469);
            dgvHocSinh.TabIndex = 11;
            dgvHocSinh.CellClick += dgvHocSinh_CellClick;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Location = new Point(247, 183);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(307, 27);
            dtpNgaySinh.TabIndex = 12;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnThoat.Location = new Point(460, 501);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 13;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // FHocSinh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1428, 547);
            Controls.Add(btnThoat);
            Controls.Add(dtpNgaySinh);
            Controls.Add(dgvHocSinh);
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
            Name = "FHocSinh";
            Text = "FHocSinh";
            Load += FHocSinh_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHocSinh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblThongTin;
        private Label lblDiaChi;
        private Label lblHoTen;
        private Label lblNgaySinh;
        private Label lblCMND;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private TextBox txtHoTen;
        private TextBox txtCMND;
        private TextBox txtDiaChi;
        private DataGridView dgvHocSinh;
        private DateTimePicker dtpNgaySinh;
        private Button btnThoat;
    }
}