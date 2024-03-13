using System;

namespace bai1_buoi2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap so n: ");
            string n = Console.ReadLine();
            int Kiemtra;
            bool isNumeric = int.TryParse(n, out Kiemtra);
            while (isNumeric == false)
            {
                Console.WriteLine("ban nhap khong phai so! xin moi nhap lai:");
                n = Console.ReadLine();
                isNumeric = int.TryParse(n, out Kiemtra);
            }
            if (Kiemtra > 0)
            {
                for (int i = 1; i < Kiemtra; i++)
                {
                    int Dem = 0;
                    for (int j = 2; j <= i / 2; j++)
                    {
                        if (i % j == 0) { Dem++; }
                    }
                    if (Dem == 0)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
            else { Console.WriteLine("ban da nhap so nho hon 0!"); }
            Console.ReadKey();
        }
    }
}
