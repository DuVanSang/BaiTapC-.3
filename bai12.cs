using System;
using System.Text;

class Program
{
    static void Main()
        
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Đặt mã hóa đầu ra của console để hỗ trợ tiếng Việt
        Console.OutputEncoding = Encoding.UTF8;

        // Khai báo số nguyên n 2 byte không dấu
        ushort n;

        // Gọi hàm để nhập giá trị của n
        n = NhapSoNguyen();

        // In ra màn hình giá trị được nhập
        Console.WriteLine($"Giá trị vừa nhập là: {n}");

        // Tính tổng bình phương các số từ 1 đến n
        long tongBinhPhuong = TinhTongBinhPhuong(n);

        // In ra console giá trị tính được
        Console.WriteLine($"Tổng bình phương các số từ 1 đến {n} là: {tongBinhPhuong}");
    }

    // Hàm đọc số nguyên 2 byte, không dấu từ bàn phím
    static ushort NhapSoNguyen()
    {
        ushort soNguyen;
        while (true)
        {
            Console.Write("Nhập số nguyên 2 byte không dấu: ");
            string input = Console.ReadLine();
            if (ushort.TryParse(input, out soNguyen))
            {
                break;
            }
            else
            {
                Console.WriteLine("Giá trị nhập không hợp lệ, vui lòng nhập lại.");
            }
        }
        return soNguyen;
    }

    // Hàm tính tổng bình phương các số từ 1 đến n
    static long TinhTongBinhPhuong(ushort n)
    {
        long tong = 0;
        for (int i = 1; i <= n; i++)
        {
            tong += (long)i * i;
        }
        return tong;
    }
}
