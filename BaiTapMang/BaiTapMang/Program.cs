using System;

namespace BaiTapMang
{
    class Program
    {
        public static void Bai59()
        {
            int n_252;
            string[] can_252 = new string[] { "Canh", "Tan", "Nham", "Quy", "Giap", "At", "Binh", "Dinh", "Mau", "Ky" };
            string[] chi_252 = new string[] { "Than", "Dau", "Tuat", "Hoi", "Ti", "Suu", "Dan", "Mao", "Thin", "Ty", "Ngo", "Mui" };
            Console.Write("Nhap nam: ");
            n_252 = int.Parse(Console.ReadLine());
            Console.WriteLine(n_252 + " - " + can_252[n_252 % 10] + " " + chi_252[n_252 % 12]);
            Console.WriteLine((n_252 + 60) + " - " + can_252[n_252 % 10] + " " + chi_252[n_252 % 12]);
        }
        public static void Bai61()
        {
            int n_252, sum_252 = 0, i_252, p_252;
            do
            {
                Console.Write("Nhap n: ");
                n_252 = int.Parse(Console.ReadLine());
            } while (n_252 < 1 || n_252 > 200);
            int[] a_252 = new int[n_252];
            for (i_252 = 0; i_252 < n_252; i_252++)
            {
                Random r = new Random();
                a_252[i_252] = r.Next(-100, 100);
                Console.Write(" " + a_252[i_252]);
            }
            for (i_252 = 0; i_252 < n_252; i_252++)
            {
                if (a_252[i_252] > 0) sum_252 += a_252[i_252];
            }
            Console.WriteLine("\nTong cac so nguyen duong: " + sum_252);

            do
            {
                Console.Write("Nhap chi so p: ");
                p_252 = int.Parse(Console.ReadLine());
            } while (p_252 < 0 || p_252 > n_252 - 1);
            for (i_252 = p_252 + 1; i_252 < n_252; i_252++)
            {
                a_252[i_252 - 1] = a_252[i_252];
            }
            n_252--;
            for (i_252 = 0; i_252 < n_252; i_252++)
            {
                Console.Write(" " + a_252[i_252]);
            }
        }
        public static void Bai63()
        {
            int n_252, i_252, c_252;
            int[] a_252;
            do
            {
                Console.Write("Nhap n: ");
                n_252 = int.Parse(Console.ReadLine());
                a_252 = new int[n_252];
            } while (n_252 < 1 || n_252 > 200);
            for (i_252 = 0; i_252 < n_252; i_252++)
            {
                Random rd_252 = new Random();
                Console.Write(" "+(a_252[i_252] = rd_252.Next(-100, 100)));
            }

            for(c_252 = i_252 = 0; i_252 < n_252; i_252++)
            {
                if (a_252[i_252] % 4 == 0 && a_252[i_252] % 10 == 6)
                {
                    c_252++;
                }
            }
            Console.Write("\nCo " + c_252 + " phan tu chia het cho 4, tan cung la 6");

            Console.WriteLine("\nNhan doi phan tu le: ");
            for (i_252 = 0; i_252 < n_252; i_252++)
            {
                if (a_252[i_252] % 2 != 0)
                {
                    a_252[i_252] *= 2;
                }
                Console.Write(" " + a_252[i_252]);
            }
        }
        public static void Bai65()
        {
            int n_252, i_252, j_252, c_252, s_252;
            int[]a_252;
            do
            {
                Console.Write("Nhap n: ");
                n_252 = int.Parse(Console.ReadLine());
                a_252 = new int[n_252];
            } while (n_252 < 1);
            Console.Write("Nhap " + n_252 + " phan tu: ");
            for (s_252=c_252=i_252 = 0; i_252 < n_252; i_252++)
            {
                a_252[i_252] = int.Parse(Console.ReadLine());
                if (a_252[i_252] < 0 && a_252[i_252] % 2 != 0) 
                {
                    c_252++;
                    s_252 += a_252[i_252];
                }
            }
            Console.WriteLine("Trung binh cong nguyen am le: " +( c_252!=0 ? (float)s_252 / c_252 : 0));
            for (i_252 = 0; i_252 < n_252 - 1; i_252++)
            {
                 for (c_252 = j_252 = i_252 + 1; j_252 < n_252; j_252++)
                    if (a_252[j_252] != a_252[i_252]) a_252[c_252++] = a_252[j_252];
                        n_252 = c_252;
            }
            for (i_252 = 0; i_252 < n_252; i_252++)
                Console.Write(" "+ a_252[i_252]);
        }
        public static void Bai67()
        {
            int n_252, i_252, j_252, t_252;
            int[] a_252;
            do
            {
                Console.Write("Nhap n: ");
                n_252 = int.Parse(Console.ReadLine());
                a_252 = new int[n_252];
            } while (n_252 < 1 || n_252 > 200);
            for (i_252 = 0; i_252 < n_252; i_252++)
            {
                Random rd_252 = new Random();
                Console.Write(" " + (a_252[i_252] = rd_252.Next(-100, 100)));
            }

            for (i_252 = 0; i_252 < n_252 - 1; i_252++)
            {
                for (j_252 = i_252 + 1; j_252 < n_252; j_252++)
                {
                    if ((a_252[i_252] % 2 == 0 && a_252[j_252] % 2 == 0 && a_252[i_252] > a_252[j_252]) ||
                        (a_252[i_252] % 2 != 0 && a_252[j_252] % 2 != 0 && a_252[i_252] < a_252[j_252]))
                    { 
                        t_252 = a_252[i_252];
                        a_252[i_252] = a_252[j_252];
                        a_252[j_252] = t_252; 
                    }
                }
            }
            Console.WriteLine("");
            for (i_252 = 0; i_252 < n_252; i_252++)
            {
                Console.Write(" " + a_252[i_252]);
            }
        }
        static void Main(string[] args)
        {
            //Bai59();
            //Bai61();
            //Bai63();
            //Bai65();
            //Bai67();
            Console.ReadKey();
        }
    }
}
