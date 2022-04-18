using System;

namespace LAB1
{
    class Program
    {
        public static void In()
        {
            ConNguoi cn = new ConNguoi();
            for (int i = 1; i <= 3; i++)
            {
                cn.Age = int.Parse(Console.ReadLine());
                if (cn.Age < 18)
                {
                    Console.WriteLine("Em be");
                }
                else if (cn.Age >= 60)
                {
                    Console.WriteLine("Nguoi gia");
                }
                else Console.WriteLine("Nguoi lon");
            }
        }
        public static void Sum()
        {
            int n, i, sum=0;
            Console.Write("Nhap n: ");
            n = int.Parse(Console.ReadLine());
            for(i = 1; i <= n; i++)
            {
                sum += i;
            }
            Console.WriteLine("Tong cua n so tu nhien dau tien: " + sum);
        }
        public static void TienLai()
        {
            Console.Write("Nhap so tien gui: ");
            float money = float.Parse(Console.ReadLine());
            Console.Write("Nhap so tien lai: ");
            float lai = float.Parse(Console.ReadLine());
            Console.Write("Nhap so nam gui: ");
            int nam = int.Parse(Console.ReadLine());
            for(int i = 1; i <= nam; i++)
            {
                money += money * lai;
            }
            Console.WriteLine("So tien nhan duoc sau " + nam + " nam la: " + money);
        }
        public static void InTamGiac()
        {
            Console.Write("Nhap chieu cao cua tam giac: ");
            int h = int.Parse(Console.ReadLine());
            for (int i = 1; i <= h; i++)
            {
                for (int j = 1; j <= 2 * h - 1; j++)
                {
                    if(i == h || j == h - i + 1 || j == h + i - 1) Console.Write("*");
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        public static void InCoToQuoc()
        {
            int x = 30, y = 10;
            for(int i = 1; i <= y; i++)
            {
                for(int j = 1; j <= x; j++)
                {
                    if (i == 1 || i == y) Console.Write("*");
                    else if (j == 1 || j == x) Console.Write("*");
                    else if() Console.Write("*");
                    else Console.Write(" ");

                }
                Console.WriteLine();

            }
        }
        static void Main(string[] args)
        {
            //In();
            //Sum();
            //TienLai();
            //InTamGiac();
            InCoToQuoc();
            Console.ReadKey();
        }
    }
}
