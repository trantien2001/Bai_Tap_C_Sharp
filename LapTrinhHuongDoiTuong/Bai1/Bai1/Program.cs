using System;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            QLCB qlcb = new QLCB();
            while (true)
            {
                Console.WriteLine("\nCHUONG TRINH QUAN LY CAN BO C#");
                Console.WriteLine("*************************MENU**************************");
                Console.WriteLine("**  1. Them moi can bo.                              **");
                Console.WriteLine("**  2. Tim kiem can bo theo tên.                     **");
                Console.WriteLine("**  3. Hien thi thong tin ve danh sach can bo.       **");
                Console.WriteLine("**  0. Thoat khoi chuong trinh.                      **");
                Console.WriteLine("*******************************************************");
                Console.Write("Nhap tuy chon: ");
                int tc_252 = int.Parse(Console.ReadLine());
                switch (tc_252)
                {
                    case 0:
                        Console.WriteLine("Ban da chon thoat chuong trinh!");
                        return;
                    case 1:
                        Console.WriteLine("1. Them moi can bo.");
                        qlcb.ThemCanBo();
                        break;
                    case 2:
                        Console.WriteLine("2. Tim kiem can bo theo tên.");
                        qlcb.TimKiemTheoTen();
                        break;
                    case 3:
                        Console.WriteLine("3. Hien thi thong tin ve danh sach can bo.");
                        qlcb.HienThiDanhSach(qlcb.getListCanBo());
                        break;
                }
            }
        }
    }
}
