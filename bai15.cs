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

        // Khai báo mảng 1 chiều các số thực 4 byte a, và cấp phát để a gồm n phần tử
        float[] a = new float[n];

        // Gọi hàm để nhập giá trị các phần tử của mảng a từ bàn phím
        NhapMangSoThuc(a, n);

        // In ra màn hình giá trị được nhập của mảng a
        Console.WriteLine("Các phần tử của mảng a là:");
        foreach (float value in a)
        {
            Console.WriteLine(value);
        }
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

    // Hàm nhập vào một mảng số thực 4 byte với số phần tử là số nguyên dương n cho trước
    static void NhapMangSoThuc(float[] mang, byte n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhập phần tử thứ {i + 1}: ");
            mang[i] = NhapSoThuc();
        }
    }
}
