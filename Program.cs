using System.Text;

namespace ConsoleApp1
{
    //Bài 2
    internal class Program
    {
        public static void Main()
    {
        // Tạo danh sách phân số
        List<PhanSo> danhSach = new List<PhanSo>
        {
            new PhanSo(1, 2),
            new PhanSo(2, 4),
            new PhanSo(3, 4),
            new PhanSo(5, 6),
            new PhanSo(1, 3)
        };
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            // In danh sách phân số
            Console.WriteLine("Danh sách phân số:");
        foreach (PhanSo ps in danhSach)
        {
            Console.WriteLine(ps);
        }

        // Random phân số từ danh sách để test
        Random rand = new Random();
            int index1 = 0; // rand.Next(danhSach.Count);
            int index2 = 1; //rand.Next(danhSach.Count);

        PhanSo ps1 = danhSach[index1];
        PhanSo ps2 = danhSach[index2];


        // Test phép toán
        Console.WriteLine($"\nKết quả cộng: {ps1.Cong(ps2)}");
        Console.WriteLine($"Kết quả trừ: {ps1.Tru(ps2)}");
        Console.WriteLine($"Kết quả nhân: {ps1.Nhan(ps2)}");
        Console.WriteLine($"Kết quả chia: {ps1.Chia(ps2)}");

        // Kiểm tra phân số có bằng nhau không
        Console.WriteLine($"\nHai phân số {ps1} và {ps2} có bằng nhau không? {ps1.BangNhau(ps2)}");
            Console.ReadKey();
    }
    }
}
