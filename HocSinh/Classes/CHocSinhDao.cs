using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HocSinh.Classes
{
    internal class CHocSinhDao
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
            finally { conn.Close(); }
        }
        public void Them(CHocSinh HS)
        {
            string sqlStr = string.Format("INSERT INTO tblHocSinh(Ten, CMND, DiaChi, NgaySinh) VALUES ('{0}','{1}','{2}','{3}')", HS.HoTen, HS.CMND, HS.DiaChi, HS.NgaySinh);
            ThucThi(sqlStr);
        }
        
        public void Xoa(CHocSinh HS)
        {

            string sqlStr = string.Format("DELETE FROM tblHocSinh WHERE CMND = '{0}'", HS.CMND);
            ThucThi(sqlStr);
        }

        public void Sua(CHocSinh HS)
        {

            string sqlStr = string.Format("UPDATE tblHocSinh SET Ten = '{0}', DiaChi = '{1}',NgaySinh = '{2}' WHERE CMND = {3}", HS.HoTen, HS.DiaChi, HS.NgaySinh, HS.CMND);
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
            catch(Exception e) 
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
