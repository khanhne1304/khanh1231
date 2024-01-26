using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using HocSinh.Classes;

namespace HocSinh.Forms
{
    public partial class FHocSinh : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        CHocSinhDao hsDao = new CHocSinhDao();
        public FHocSinh()
        {
            InitializeComponent();
        }

        private void dgvHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHocSinh.Rows[e.RowIndex];
                txtHoTen.Text = row.Cells["Ten"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                txtCMND.Text = row.Cells["Cmnd"].Value.ToString();
                object ngaySinhValue = row.Cells["NgaySinh"].Value;
                dtpNgaySinh.Value = ngaySinhValue != DBNull.Value ? Convert.ToDateTime(ngaySinhValue) : DateTime.Now;
            }
        }

        private void FHocSinh_Load(object sender, EventArgs e)
        {
            hsDao.LoadForm(dgvHocSinh);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            CHocSinh hs = new CHocSinh(txtHoTen.Text, txtCMND.Text, txtDiaChi.Text, dtpNgaySinh.Value.Date);
            hsDao.Them(hs);
            FHocSinh_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            CHocSinh hs = new CHocSinh(txtHoTen.Text, txtCMND.Text, txtDiaChi.Text, dtpNgaySinh.Value.Date);
            hsDao.Xoa(hs);
            FHocSinh_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            CHocSinh hs = new CHocSinh(txtHoTen.Text, txtCMND.Text, txtDiaChi.Text, dtpNgaySinh.Value.Date);
            hsDao.Sua(hs);
            FHocSinh_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
