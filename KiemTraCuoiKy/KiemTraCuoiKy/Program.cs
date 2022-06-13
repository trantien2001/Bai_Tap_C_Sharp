using System;
using System.Collections;

namespace KiemTraCuoiKy
{
    class Program : Nguoi
    {
        static void Main(string[] args)
        {
            int yeuCau_252;
            int n_252 = 0;
            KhachSan[] array_252;
            do
            {
                Console.WriteLine("Chon cac yeu cau duoi day: ");
                Console.WriteLine("1. Them moi khach.");
                Console.WriteLine("2. Xoa khach theo so cmnd.");
                Console.WriteLine("3. Tinh tien thue phong cho khach.");
                Console.WriteLine("4. Thong ke thong tin thue theo thang, quy, nam.");
                Console.WriteLine("5. Dua ra thong tin phong duoc dat nhieu nhat, it nhat trong nam.");
                Console.WriteLine("6. Tinh tong tien thue theo thang, quy, nam");
                do
                {
                    Console.WriteLine("Nhap yeu cau: ");
                    yeuCau_252 = int.Parse(Console.ReadLine());
                } while (yeuCau_252 > 7 || yeuCau_252 < 0);
                if (yeuCau_252 == 1)
                {
                    ++n_252;
                }

                array_252 = new KhachSan[n_252];
                switch (yeuCau_252)
                {

                    case 1:
                        for (int i_252 = n_252-1; i_252 < n_252; i_252++)
                        {
                            Console.WriteLine("Nhap nguoi thu " + (i_252 + 1) + ": ");
                            array_252[i_252] = new KhachSan();
                            array_252[i_252].nhapThongTinCanQuanLy();
                            }
                        break;
                    case 2:
                        int a_252 = 0, pos = 0;
                        Nguoi nguoi = new Nguoi();
                        Console.WriteLine("Nhap so cmnd cua khach can xoa: ");
                        int cmnd_252 = int.Parse(Console.ReadLine());
                        for (int i_252 = 0; i_252 < n_252; i_252++)
                        {
                            if (nguoi.Cmnd_252 == cmnd_252);
                            pos = i_252;
                        }
                        while (a_252 != pos - 1)
                            a_252++;
                        while (a_252 < n_252)
                        {
                            array_252[a_252] = array_252[a_252 + 1];
                            a_252++;
                        }
                        n_252--;
                        break;
                    case 3:
                        for (int i_252 = 0; i_252 < n_252; i_252++)
                        {
                            Console.WriteLine("Thong tin nguoi thu " + (i_252 + 1) + ": ");
                            array_252[i_252].hienThiThongTinCanQuanLy();
                            Console.WriteLine("Tien phong cua khach: " + array_252[i_252].tinhTienThue());
                        }
                        break;
                    case 4:

                        break;
                    case 5:

                        break;
                    case 6:

                        break;
                }

            } while (true);
            Console.ReadKey();
        }
    }
}
