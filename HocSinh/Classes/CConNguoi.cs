using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HocSinh.Classes
{
    internal class CConNguoi
    {
        public string HoTen;
        public string CMND;
        public string DiaChi;
        public DateTime NgaySinh;

        public CConNguoi(string hoTen, string cMND, string diaChi, DateTime ngaySinh)
        {
            HoTen = hoTen;
            CMND = cMND;
            DiaChi = diaChi;
            NgaySinh = ngaySinh;
        }
    }
}
