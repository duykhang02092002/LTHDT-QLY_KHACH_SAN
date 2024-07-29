using static LTHDT_QLY_KHACH_SAN.Khách_sạn;

class Program
{
    static void Main(string[] args)
    {
        KhachSan khachSan = new KhachSan();

        // Nhập thông tin khách trọ
        khachSan.NhapThongTinKhach();

        // Hiển thị thông tin các khách trọ
        khachSan.HienThiThongTinKhach();

        // Xóa thông tin của một khách trọ
        Console.WriteLine("\nNhập số CMND của khách hàng cần xóa:");
        string soCMNDCanXoa = Console.ReadLine();
        khachSan.XoaThongTinKhach(soCMNDCanXoa);

        // Tính số tiền cần trả khi một khách hàng trả phòng
        Console.WriteLine("\nNhập số CMND của khách hàng cần tính tiền phòng:");
        string soCMNDCanTinhTien = Console.ReadLine();
        khachSan.TinhTienTraPhong(soCMNDCanTinhTien);
    }
}
