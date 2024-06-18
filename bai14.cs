using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Đặt mã hóa đầu ra của console để hỗ trợ tiếng Việt
        Console.OutputEncoding = Encoding.UTF8;

        // Khai báo số thực x 4 byte
        float x;

        // Gọi hàm để nhập giá trị của x
        x = NhapSoThuc();

        // In ra màn hình giá trị được nhập
        Console.WriteLine($"Giá trị vừa nhập là: {x}");
    }

    // Hàm đọc số thực 4 byte (float) từ bàn phím
    static float NhapSoThuc()
    {
        float soThuc;
        while (true)
        {
            Console.Write("Nhập số thực 4 byte: ");
            string input = Console.ReadLine();
            if (float.TryParse(input, out soThuc))
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
