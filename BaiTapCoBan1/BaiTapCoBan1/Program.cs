using System;

namespace BaiTapCoBan1
{
    class Program
    {
        public static void Bai1() // Kiem tra so nguyen am hay duong
        {
            Console.Write("Nhap vao mot so: ");
            string a = Console.ReadLine();
            if(Convert.ToInt32(a) > 0)
            {
                Console.WriteLine("Day la so nguyen duong");
            }
            else
            {
                Console.WriteLine("Day la so nguyen am");
            }
        }
        public static void Bai2() // Nhap vao 1 so in ra chu tuong uong
        {
            Console.Write("Nhap vao mot so: ");
            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 0: Console.WriteLine("Khong"); break;
                case 1: Console.WriteLine("Mot"); break;
                case 2: Console.WriteLine("Hai"); break;
                case 3: Console.WriteLine("Ba"); break;
                case 4: Console.WriteLine("Bon"); break;
                case 5: Console.WriteLine("Nam"); break;
                case 6: Console.WriteLine("Sau"); break;
                case 7: Console.WriteLine("Bay"); break;
                case 8: Console.WriteLine("Tam"); break;
                case 9: Console.WriteLine("Chin"); break;
            }
        }
        public static void Bai3() // Kiem tra 3 canh co tao thanh tam giac
        {
            Console.Write("Nhap so thu 1: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu 2: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu 3: ");
            int c = int.Parse(Console.ReadLine());
            if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("Day la tam giac");
            }
            else
            {
                Console.WriteLine("Day khong phai la tam giac");
            }
        }
        public static void Bai4() // Kiem tra 3 canh co tao thanh tam giac vuong
        {
            Console.Write("Nhap so thu 1: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu 2: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu 3: ");
            int c = int.Parse(Console.ReadLine());
            if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
            {
                Console.WriteLine("Day la tam giac vuong");
            }
            else
            {
                Console.WriteLine("Day khong phai la tam giac vuong");
            }
        }
        static void Main(string[] args)
        {
            //Bai1();
            //Bai2();
            //Bai3();
            //Bai4();
            Console.ReadKey();
        }
    }
}
