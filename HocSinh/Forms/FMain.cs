using HocSinh.Forms;

namespace HocSinh
{
    public partial class FMain : Form
    {
        FHocSinh fHocSinh;
        FGiaoVien fGiaoVien;
        public FMain()
        {
            InitializeComponent();
        }

        private void btnDanhSachHocSInh_Click(object sender, EventArgs e)
        {
            fHocSinh = new FHocSinh();
            fHocSinh.Show();
        }

        private void btnDanhSachGiaoVien_Click(object sender, EventArgs e)
        {
            fGiaoVien = new FGiaoVien();
            fGiaoVien.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}