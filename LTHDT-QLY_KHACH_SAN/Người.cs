using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT_QLY_KHACH_SAN
{
    internal class Nguoi
    {
     // Thuộc tính của mỗi người
     public string HoTen { get; set; }
     public DateTime NgaySinh { get; set; }
     public string SoCMND { get; set; }

     // Constructor để khởi tạo đối tượng Người
         public Nguoi(string hoTen, DateTime ngaySinh, string soCMND)
         {
          HoTen = hoTen;
          NgaySinh = ngaySinh;
          SoCMND = soCMND;
         }
    }

}
