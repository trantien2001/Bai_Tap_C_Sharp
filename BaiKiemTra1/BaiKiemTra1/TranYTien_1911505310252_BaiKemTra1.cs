using System;

namespace BaiKiemTra1
{
    class Program
    {
        public static void Bai1()
        {
            Console.Write("Nhap so thu 1: ");
            float x_52 = float.Parse(Console.ReadLine());
            Console.Write("Nhap so thu 2: ");
            float y_52 = float.Parse(Console.ReadLine());
            Console.WriteLine("Tong 2 so: " + (x_52 + y_52));
            Console.WriteLine("Hieu 2 so: " + (x_52 - y_52));
            Console.WriteLine("Tich 2 so: " + (x_52 * y_52));
            Console.WriteLine("Thuong 2 so: " + (x_52 / y_52));
        }
        public static void Bai2()
        {
            for (int i_52 = 1; i_52 <= 20; i_52++)
            {
                Console.WriteLine();
                for (int j_52 = 1; j_52 <= 30; j_52++)
                {

                }
            }

            int xc = 320, yc = 240, r = 200;
            int d = 270;
            while (1)
            {
                for (int i = 0; i <= 5; i++)
                {
                    int x = xc + (int)(r * Math.Cos(d2r(d)));
                    int y = yc + (int)(r * Math.Sin(d2r(d)));
                    if (i == 0)
                        moveto(x, y);
                    else
                        lineto(x, y);
                    d += 144;
                    setcolor(i + 1);
                }
                d += 5;
                delay(100);
            }
        }

        public static void Bai3()
        {
            int x_52, a_52 = 0;
            Console.Write("Nhap so thap phan: ");
            x_52 = int.Parse(Console.ReadLine());
            double b_52 = 0;
            while (x_52 > 0)
            {
                b_52 += (x_52 % 2) * Math.Pow(10, a_52);
                ++a_52;
                x_52 /= 2;
            }
            Console.WriteLine("So nhi phan la: " + b_52);
        }
        public static void Bai4()
        {
            Console.WriteLine("Thong tin cua ban than");
            Console.WriteLine("Họ ten: Tran Y Tien");
            Console.WriteLine("Lop: 19T2");
            Console.WriteLine("Ma sinh vien: 1911505310252");

        }
        static void Main(string[] args)
        {
            //Bai1();
            //Bai2();
            //Bai3();
            Bai4();
            Console.ReadKey();
        }
    }
}
