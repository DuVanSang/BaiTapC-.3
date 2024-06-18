using System;
using System.Text;
using System.Linq;

class Program
{
    
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Đặt mã hóa đầu ra của console để hỗ trợ tiếng Việt
        Console.OutputEncoding = Encoding.UTF8;

        // Khai báo biến xâu kí tự st
        string st;

        // Nhập st từ bàn phím
        Console.Write("Nhập xâu kí tự: ");
        st = Console.ReadLine();

        // Kiểm tra nếu st là "#"
        if (st == "#")
        {
            // Phát tiếng beep
            Console.Beep();
        }
        else
        {
            // Gọi hàm để in ra số từ của st
            int soTu = DemSoTu(st);
            Console.WriteLine($"Số từ trong xâu kí tự là: {soTu}");
        }
    }

    // Hàm static đếm số các từ của 1 xâu kí tự
    static int DemSoTu(string xau)
    {
        if (string.IsNullOrWhiteSpace(xau))
        {
            return 0;
        }

        // Tách xâu theo các dấu phân cách thông thường (khoảng trắng, dấu chấm, dấu phẩy, ...)
        char[] delimiters = new char[] { ' ', '\r', '\n', '.', ',', ';', '!', '?' };
        string[] words = xau.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

        return words.Length;
    }
}