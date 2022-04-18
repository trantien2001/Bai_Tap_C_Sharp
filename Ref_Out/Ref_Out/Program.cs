using System;

namespace Ref_Out
{
    class Program
    {
        static void Multi(double x)
        {
            x *= 2;
        }
        static void MultiRef(ref double x)
        {
            x *= 2;
        }
        static void MultiOut(out double x)
        {
            x = 3;
            x *= 2;
        }
        public static void Array()
        {
            Console.Write("Nhap bao nhieu so: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            int max=0;
            for(int i = 0; i < n; i++)
            {
                Console.Write("Nhap so thu " + i+ " : ");
                a[i] = int.Parse(Console.ReadLine());
                if (max < a[i]) max = a[i];
            }
            Console.WriteLine("Max: " + max);
        }
        static void Main(string[] args)
        {
            //double so = 2;
            //Console.WriteLine("Gia tri so ban dau: " + so);
            //Multi(so);
            //Console.WriteLine("KQ hàm Multi: " + so);
            //MultiRef(ref so);
            //Console.WriteLine("KQ hàm MultiRef: " + so);
            //MultiOut(out so);
            //Console.WriteLine("KQ hàm MultiOut: " + so);
            Array();
            Console.ReadKey();
        }
    }
}
