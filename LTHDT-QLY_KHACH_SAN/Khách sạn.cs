using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT_QLY_KHACH_SAN
{
    internal class Khách_sạn
    {
        public class KhachSan
        {
            // Thuộc tính của khách sạn
            private List<Nguoi> danhSachKhach = new List<Nguoi>();

            // Phương thức để nhập thông tin khách trọ
            public void NhapThongTinKhach()
            {
                Console.WriteLine("Nhập số lượng khách trọ:");
                int n = int.Parse(Console.ReadLine());

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Nhập thông tin cho khách thứ {i + 1}:");
                    Console.Write("Họ và tên: ");
                    string hoTen = Console.ReadLine();
                    Console.Write("Ngày sinh (dd/mm/yyyy): ");
                    DateTime ngaySinh = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    Console.Write("Số CMND: ");
                    string soCMND = Console.ReadLine();

                    Nguoi khach = new Nguoi(hoTen, ngaySinh, soCMND);
                    danhSachKhach.Add(khach);
                    Console.WriteLine("Thông tin khách đã được nhập.");
                }
            }

            // Phương thức để hiển thị thông tin các khách trọ đang ở khách sạn
            public void HienThiThongTinKhach()
            {
                Console.WriteLine("\nDanh sách các khách trọ đang ở khách sạn:");
                foreach (var khach in danhSachKhach)
                {
                    Console.WriteLine($"Họ và tên: {khach.HoTen}, Ngày sinh: {khach.NgaySinh.ToString("dd/MM/yyyy")}, Số CMND: {khach.SoCMND}");
                }
            }

            // Phương thức để xóa thông tin của một khách trọ dựa trên số CMND
            public void XoaThongTinKhach(string soCMND)
            {
                for (int i = 0; i < danhSachKhach.Count; i++)
                {
                    if (danhSachKhach[i].SoCMND == soCMND)
                    {
                        danhSachKhach.RemoveAt(i);
                        Console.WriteLine("Đã xóa thông tin của khách hàng có số CMND này.");
                        return;
                    }
                }
                Console.WriteLine("Không tìm thấy khách hàng có số CMND này.");
            }

            // Phương thức để tính số tiền cần phải trả khi khách hàng trả phòng trọ
            public void TinhTienTraPhong(string soCMND)
            {
                foreach (var khach in danhSachKhach)
                {
                    if (khach.SoCMND == soCMND)
                    {
                        // Giả sử giá phòng đã được xác định trước đó, ví dụ:
                        int giaPhong = 100000; // Giá phòng mỗi ngày
                        Console.WriteLine($"Số tiền cần trả cho khách hàng {khach.HoTen} là: {danhSachKhach.Count * giaPhong} VNĐ.");
                        return;
                    }
                }
                Console.WriteLine("Không tìm thấy khách hàng có số CMND này.");
            }
        }
    }
}