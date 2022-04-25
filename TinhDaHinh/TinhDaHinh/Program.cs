using System;

namespace TinhDaHinh
{
    
    class Program
    {
        static void Main(string[] args)
        {
            int hh_252;
            Console.WriteLine("1 - hinh tam giac");
            Console.WriteLine("2 - hinh tu giac");
            Console.WriteLine("3 - hinh binh hanh ");
            Console.WriteLine("4 - hinh chu nhat ");
            Console.WriteLine("5 - hinh vuong ");
            Console.WriteLine("Nhap hinh: ");
            Console.WriteLine("=====================");
            do
            {
                hh_252 = int.Parse(Console.ReadLine());
            } while (hh_252 < 1 || hh_252 > 5);
            switch (hh_252)
            {
                case 1:
                    HinhTamGiac tamg_252 = new HinhTamGiac();
                    tamg_252.xuat();
                    break;
                case 2:
                    HinhTuGiac tug_252 = new HinhTuGiac();
                    tug_252.xuat();
                    break;
                case 3:
                    HinhBinhHanh hbh_252 = new HinhBinhHanh();
                    hbh_252.xuat();
                    break;
                case 4:
                    HinhChuNhat hcn_252 = new HinhChuNhat();
                    hcn_252.xuat();
                    break;
                case 5:
                    HinhVuong hv_252 = new HinhVuong();
                    hv_252.xuat();
                    break;
                default:
                    break;
            }
            Console.ReadKey();
        }
    }
}
