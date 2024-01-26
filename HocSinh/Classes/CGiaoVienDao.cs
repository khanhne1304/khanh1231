using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HocSinh.Classes
{
    internal class CGiaoVienDao
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public void ThucThi(string querry)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(querry, conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Thanh cong");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); 
            }
        }
        public void Them(CGiaoVien GV)
        {
            string sqlStr = string.Format("INSERT INTO tblGiaoVien(Ten, CMND, DiaChi, NgaySinh) VALUES ('{0}','{1}','{2}','{3}')", GV.HoTen, GV.CMND, GV.DiaChi, GV.NgaySinh);
            ThucThi(sqlStr);
        }

        public void Sua(CGiaoVien GV)
        {

            string sqlStr = string.Format("UPDATE tblGiaoVien SET Ten = '{0}', DiaChi = '{1}',NgaySinh = '{2}' WHERE CMND = {3}", GV.HoTen, GV.DiaChi, GV.NgaySinh, GV.CMND);
            ThucThi(sqlStr);
        }

        public void Xoa(CGiaoVien GV)
        {

            string sqlStr = string.Format("DELETE FROM tblGiaoVien WHERE CMND = '{0}'", GV.CMND);
            ThucThi(sqlStr);
        }

        public void LoadForm(DataGridView dgv)
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT *FROM tblHocSinh");
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dtSinhVien = new DataTable();
                sqlDataAdapter.Fill(dtSinhVien);
                dgv.DataSource = dtSinhVien;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
