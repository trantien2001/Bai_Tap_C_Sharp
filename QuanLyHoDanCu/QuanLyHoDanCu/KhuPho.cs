using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHoDanCu
{
    class KhuPho : HoGiaDinh
    {
        private HoGiaDinh[] dsHoGiaDinh_252 = new HoGiaDinh[10];
        private int soHoGiaDinh_252;

        public void InThongTinKhuPho()
        {
            Console.WriteLine("Nhap so ho gia dinh: ");
            soHoGiaDinh_252 = int.Parse(Console.ReadLine());
            for (int i_252 = 1; i_252 <= soHoGiaDinh_252; i_252++)
            {
                Console.WriteLine("Nhap ho gia dinh thu " + i_252);
                dsHoGiaDinh_252[i_252] = new HoGiaDinh();
                dsHoGiaDinh_252[i_252].NhapHoGiaDinh();
            }
            Console.WriteLine("Thong tin tat ca ho gia dinh: ");
            for (int i_252 = 1; i_252 <= soHoGiaDinh_252; i_252++)
            {
                Console.WriteLine("Ho gia dinh thu " + i_252);
                dsHoGiaDinh_252[i_252].InThongTinHoGiaDinh();
            }
        }
    }
}
