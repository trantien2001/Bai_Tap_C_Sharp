using System;

namespace BaiTapCoBan2
{
    class Program
    {
        public static void Bai1()
        {
            Console.Write("Nhap dien tich mat cau: ");
            float s_252 = float.Parse(Console.ReadLine());
            //float r_252 = (float) Math.Sqrt(s_252 / (4 * Math.PI));
            //float v_252 = (float) (Math.Pow(r_252, 3) * Math.PI * 4 / 3);
            float v_252 = ((float)(4 * Math.PI * Math.Pow(Math.Sqrt(s_252 / (4 * Math.PI)), 3) / 3));
            Console.WriteLine("The tich hinh cau: " + v_252);
        }
        public static void Bai2()
        {
            Console.WriteLine("Nhap tao do diem A: ");
            Console.Write("xA = ");
            float xA_252 = float.Parse(Console.ReadLine());
            Console.Write("yA = ");
            float yA_252 = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap tao do diem B: ");
            Console.Write("xB = ");
            float xB_252 = float.Parse(Console.ReadLine());
            Console.Write("yB = ");
            float yB_252 = float.Parse(Console.ReadLine());
            float AB_252 = (float)Math.Sqrt(Math.Pow((xB_252 - xA_252), 2) + Math.Pow((yB_252 - yA_252), 2));
            Console.WriteLine("Khoang cach AB la: " + AB_252);
        }
        public static void Bai3()
        {
            Console.WriteLine("Nhap tao do diem C: ");
            Console.Write("xC = ");
            float xC_252 = float.Parse(Console.ReadLine());
            Console.Write("yC = ");
            float yC_252 = float.Parse(Console.ReadLine());
            
            Console.Write("Nhap ban kinh R: ");
            float R_252 = float.Parse(Console.ReadLine());

            Console.WriteLine("Nhap tao do diem M: ");
            Console.Write("xM = ");
            float xM_252 = float.Parse(Console.ReadLine());
            Console.Write("yM = ");
            float yM_252 = float.Parse(Console.ReadLine());

            float d = (float)(R_252 - Math.Sqrt(Math.Pow((xM_252 - xC_252), 2) + Math.Pow((yM_252 - yC_252), 2)));
            if (d > 0)
            {
                Console.Write("M nam trong duong tron");
            } else if (d < 0)
            {
                Console.Write("M nam ngoai duong tron");
            } else Console.Write("M nam tren duong tron");
        }
        public static void Bai6() {
            int a, b, c, t;
            Console.WriteLine("Nhap 3 so: ");
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            c = int.Parse(Console.ReadLine());
            if (a < b) { t = a; a = b; b = t; }
            if (a < c) { t = a; a = c; c = t; }
            if (b < c) { t = b; b = c; c = t; }
            Console.Write("Thu tu tang dan: " + c + " - " + b + " - " + a);
        }
        public static void Bai11() {
            Random rd = new Random();
            int h_252 = 0, c_252 = 0;
            string []a_252 = { "b", "d", "k" };
            int index = rd.Next(a_252.Length);
            Console.Write("Nhap ky tu (b-d-k): ");
            string kt_252 = Console.ReadLine();
            switch (kt_252)
            {
                case "b":
                    switch (a_252[index])
                    {
                        case "b": break;
                        case "d": h_252++; break;
                        case "k": c_252++; break;
                    }
                    break;
                case "d":
                    switch (a_252[index])
                    {
                        case "b": c_252++; break;
                        case "d": break;
                        case "k": h_252++; break;
                    }
                    break;
                case "k":
                    switch (a_252[index])
                    {
                        case "b": h_252++; break;
                        case "d": c_252++; break;
                        case "k": break;
                    }
                    break;
            }
            Console.WriteLine("Computer: " + a_252[index]);
            Console.WriteLine("Ty so human - computer: " + h_252 + " - " + c_252);

        }
        public static void Bai18()
        {
            Console.Write("Nhap so gio: ");
            int h_252 = int.Parse(Console.ReadLine());
            int t_252 = h_252 / 24 / 7;
            int n_252 = (h_252 % (24 * 7)) / 24;
            int g_252 = (h_252 % (24 * 7)) % 24;
            Console.WriteLine(t_252 + " tuan, " + n_252 + " ngay, " + g_252 + " gio");
        }
        public static void Bai20() 
        {
            Console.Write("Nhap so kw tieu thu: ");
            int kw_252 = int.Parse(Console.ReadLine());
            int money_252 = kw_252 * 500;
            if (kw_252 > 100) money_252 += (kw_252 - 100) * 300;
            if (kw_252 > 250) money_252 += (kw_252 - 250) * 200;
            if (kw_252 > 350) money_252 += (kw_252 - 350) * 500;
            Console.WriteLine("Chi phi: " + money_252);

        }
        public static void Bai22() 
        {
            int n_252, i_252, count_252=0, sum_252=0;
            Console.Write("Nhap so: ");
            n_252 = int.Parse(Console.ReadLine());
            Console.Write("Cac uoc so: ");
            for (i_252 = 1; i_252 <= n_252; i_252++)
            {
                if (n_252 % i_252 == 0)
                {
                    Console.Write(i_252 + " ");
                    count_252++;
                    sum_252 += i_252;
                }
            }
            Console.WriteLine("\nCo " + count_252 + " uoc so, tong la: " + sum_252);
        }
        public static void Bai27()
        {
            int n_252,i_252=2;
            Console.Write("Nhap n: ");
            n_252 = int.Parse(Console.ReadLine());
            while (n_252 > 1)
            {
                while (n_252 % i_252!=0) ++i_252;
                n_252 /= i_252;
                Console.Write(n_252 >1 ? (i_252 + " * ") : i_252);
            }
        }
        public static bool kt_snt(int n)
        {
            int i;
            if (n == 2) return true;
            if (n < 2 || n % 2 == 0) return false;
            for (i = 3; i < (n >> 1); i += 2)
                if (n % i == 0) return false;
            return true;
        }
        public static void Bai35()
        {
            Console.Write("Nhap n: ");
            int n_252 = int.Parse(Console.ReadLine());
            if (kt_snt(n_252))
                Console.WriteLine(n_252+" la so nguyen to");
            else
            {
                Console.WriteLine(n_252+" khong la so nguyen to");
                int i_252;
                for (i_252 = n_252 - 1; i_252 >= 2; --i_252)
                    if (kt_snt(i_252))
                    {
                        Console.WriteLine("So nguyen to be hon gan nhat: " + i_252);
                        break;
                    }
            }
        }
        public static void Bai36()
        {
            int n_252, count_252=0, k_252=2, i_252;
            Console.Write("Nhap n: ");
            n_252 = int.Parse(Console.ReadLine());

            while (count_252 < n_252)
            { /* vòng lặp kiểm tra k có phải là số nguyên tố */
                for (i_252 = 2; i_252 * i_252 <= k_252; ++i_252)
                    if (k_252 % i_252 == 0) break;
                if (i_252 * i_252 > k_252)
                {
                    Console.Write(k_252 + " ");
                    count_252++;
                }
                k_252++;
            }
        }

        static void Main(string[] args)
        {
            // Bai1();     // Bài 1: Nhập vào diện tích S của một mặt cầu. Tính thể tích V của hình cầu này.

            // Bai2();     // Bài 2: Nhập vào tọa độ 2 điểm A(xA, yA) và B(xB, yB). Tính khoảng cách AB.

            // Bai3();     // Bài 3: Viết chương trình nhập vào tọa độ (xC, yC) là tâm của một đường tròn, và R
            // là bán kính của đường tròn đó.Nhập vào tọa độ(xM, yM) của điểm M.Xác định điểm
            // M nằm trong, trên hay nằm ngoài đường tròn.

            // Bai6();     // Bài 6: Viết chương trình nhập vào ba số nguyên. Hãy in ba số này ra màn hình
            // theo thứ tự tăng dần và chỉ dùng tối đa một biến phụ.

            // Bai11(); // Viết trò chơi bao - đá - kéo với luật chơi: bao thắng đá, đá thắng kéo, kéo
            // thắng bao. Người dùng nhập vào một trong ba ký tự b(bao), d(đá), k(kéo); máy
            // tính sinh ngẫu nhiên một trong ba ký tự trên, thông báo kết quả chơi.


            // Bai18(); // Bài 18: Viết chương trình nhập vào số giờ, xuất ra số tương đương tính theo tuần, theo ngày và theo giờ.

            // Bai20(); // Viết chương trình nhập số kW điện đã tiêu thụ. Tính tiền điện phải trả

            // Bai22(); // Bài 22: Viết chương trình liệt kê, đếm và tính tổng các ước số của số nguyên dương n

            // Bai27(); // Bài 27: Nhập vào một số nguyên dương n, phân tích n thành các thừa số nguyên tố

            // Bai35(); // Bài 35: Viết chương trình kiểm tra một số nguyên dương n có là số nguyên tố hay không.
            // Nếu không thì phải xác định số nguyên tố gần n nhất và bé hơn n.

            // Bai36(); // Bài 36: Viết chương trình in ra n số nguyên tố đầu tiên

            Console.ReadKey();
        }
    }
}
