using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Đặt mã hóa đầu ra của console để hỗ trợ tiếng Việt
        Console.OutputEncoding = Encoding.UTF8;

        // Khai báo biến số thực 8 byte x
        double x;

        // Gọi hàm để đọc vào số x
        x = NhapSoThuc8Byte();

        // Hiển thị giá trị căn bậc 2 của x
        Console.WriteLine($"Căn bậc 2 của {x} là: {Math.Sqrt(x)}");
    }

    // Hàm static đọc vào số thực 8 byte (double). Nhập sai thì nhập lại.
    static double NhapSoThuc8Byte()
    {
        double soThuc;
        while (true)
        {
            Console.Write("Nhập số thực 8 byte: ");
            string input = Console.ReadLine();
            if (double.TryParse(input, out soThuc))
            {
                break;
            }
            else
            {
                Console.WriteLine("Giá trị nhập không hợp lệ, vui lòng nhập lại.");
            }
        }
        return soThuc;
    }
}