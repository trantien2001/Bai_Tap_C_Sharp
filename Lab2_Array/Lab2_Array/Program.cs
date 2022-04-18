using System;

namespace Lab2_Array
{
    class Program
    {
        public static void Bai58()
        {
            int i_252, j_252, n_252;
            Console.Write("Nhap n: ");
            n_252 = int.Parse(Console.ReadLine());
            int[] a_252 = new int[n_252];
            for (i_252 = 2; i_252 <= n_252; i_252++)
            {
                if ()
                {
                    Console.Write(i_252);
                    for (j_252 = i_252 + 1; j_252 <= n_252; j_252 += i_252)
                    {
                        a_252[j_252] = 1;
                    }
                }
            }
        }
        public static void Bai59()
        {
            int n;
            string[] can = new string[] { "Canh", "Tan", "Nham", "Quy", "Giap", "At", "Binh", "Dinh", "Mau", "Ky" };
            string[] chi = new string[] { "Than", "Dau", "Tuat", "Hoi", "Ti", "Suu", "Dan", "Mao", "Thin", "Ty", "Ngo", "Mui" };
            Console.Write("Nhap nam: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine(n + " - " + can[n % 10] + " " + chi[n % 12]);
            Console.WriteLine((n + 60) + " - " + can[n % 10] + " " + chi[n % 12]);
        }
        //public static void Bai60()
        //{

        //}
        public static void Bai61()
        {
            int n, sum = 0, i, p;
            do
            {
                Console.Write("Nhap n: ");
                n = int.Parse(Console.ReadLine());
            } while (n < 1|| n > 200);
            int[] a = new int[n];
            for (i = 0; i < n; i++)
            {
                Random r = new Random();
                a[i] = r.Next(-100, 100);
                Console.Write(" " +a [i]);
            }
            for (i = 0; i < n; i++)
            {
                if (a[i] > 0) sum += a[i];
            }
            Console.WriteLine("\nTong cac so nguyen duong: " + sum);

            do
            {
                Console.Write("Nhap chi so p: ");
                p = int.Parse(Console.ReadLine());
            } while (p < 0 || p > n - 1);
            for (i = p + 1; i < n; i++)
            {
                a[i - 1] = a[i];
            }
            n--;
            for (i = 0; i < n; i++)
            {
                Console.Write(" " + a[i]);
            }
        }
        public static void Bai62()
        {
            int n, i, j, s1 = 0, s2 = 0;
            do
            {
                Console.Write("Nhap n: ");
                n = int.Parse(Console.ReadLine());
            } while (n < 1);
            int[] a = new int[n];
            for (i = 0; i < n; i++)
            {
                Random r = new Random();
                a[i] = r.Next(10, 20);
                Console.Write(" " + a[i]);
            }
            for (i = 0; i < n; i++)
            {
                if (i % 2 == 0 && a[i] % 2 == 1) s1 += a[i];
                if (i % 2 == 1 && a[i] % 2 == 0) s2 += a[i];
            }
            Console.Write("\nTong cac so chan o vi tri le (" + s2 + ") ");
            Console.Write(s1 == s2 ? "bang " : "khac ");
            Console.WriteLine("Tong cac so le o vi tri chan (" + s1 + ")");

            Console.WriteLine("Cac cap nguyen to cung nhau: ");
            //for (i = 0; i < n; i++)
            //{
            //    for (j = i + 1; j < n; j++)
            //    {
            //        if()
            //    }
            //}
        }
        //public int gcd(int a, int b)
        //{
        //    return (a ? b : gcd(b % a, a));
        //}
        static void Main(string[] args)
        {
            //Bai59();
            //Bai60();
            //Bai61();
            Bai62();
            Console.ReadKey();
        }
    }
}
