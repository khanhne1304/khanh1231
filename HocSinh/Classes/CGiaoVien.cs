using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HocSinh.Classes
{
    internal class CGiaoVien : CConNguoi
    {
        public CGiaoVien(string hoTen, string cMND, string diaChi, DateTime ngaySinh) : base(hoTen, cMND, diaChi, ngaySinh)
        { }
    }
}
