using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        // Đặt mã hóa đầu ra của console để hỗ trợ tiếng Việt
        Console.OutputEncoding = Encoding.UTF8;

        // Khai báo số nguyên n 1 byte không dấu
        byte n;

        // Gọi hàm để nhập giá trị của n
        n = NhapSoNguyen();

        // In ra màn hình giá trị được nhập
        Console.WriteLine($"Giá trị vừa nhập là: {n}");
    }

    // Hàm đọc số nguyên 1 byte, không dấu từ bàn phím, nằm trong khoảng từ 2 đến 10
    static byte NhapSoNguyen()
    {
        byte soNguyen;
        while (true)
        {
            Console.Write("Nhập số nguyên 1 byte không dấu (từ 2 đến 10): ");
            string input = Console.ReadLine();
            if (byte.TryParse(input, out soNguyen) && soNguyen >= 2 && soNguyen <= 10)
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
}
