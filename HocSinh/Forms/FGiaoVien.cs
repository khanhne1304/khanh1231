using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HocSinh.Classes;

namespace HocSinh.Forms
{
    public partial class FGiaoVien : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        CGiaoVienDao gvDao = new CGiaoVienDao();    
        public FGiaoVien()
        {
            InitializeComponent();
        }

        private void FGiaoVien_Load(object sender, EventArgs e)
        {
            gvDao.LoadForm(dgvGiaoVien);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            CGiaoVien gv = new CGiaoVien(txtHoTen.Text, txtCMND.Text, txtDiaChi.Text, dtpNgaySinh.Value.Date);
            gvDao.Them(gv);
            FGiaoVien_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            CGiaoVien gv = new CGiaoVien(txtHoTen.Text, txtCMND.Text, txtDiaChi.Text, dtpNgaySinh.Value.Date);
            gvDao.Sua(gv);
            FGiaoVien_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            CGiaoVien gv = new CGiaoVien(txtHoTen.Text, txtCMND.Text, txtDiaChi.Text, dtpNgaySinh.Value.Date);
            gvDao.Xoa(gv);
            FGiaoVien_Load(sender, e);
        }

        private void dgvGiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvGiaoVien.Rows[e.RowIndex];
                txtHoTen.Text = row.Cells["Ten"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                txtCMND.Text = row.Cells["Cmnd"].Value.ToString();
                object ngaySinhValue = row.Cells["NgaySinh"].Value;
                dtpNgaySinh.Value = ngaySinhValue != DBNull.Value ? Convert.ToDateTime(ngaySinhValue) : DateTime.Now;
            }
        }
    }
}
