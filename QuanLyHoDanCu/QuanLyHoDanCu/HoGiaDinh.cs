using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHoDanCu
{
    class HoGiaDinh : Nguoi
    {
        private int soThanhVien_252;
        private int soNha_252;
        private Nguoi[] tv_252 = new Nguoi[10];

        public int SoThanhVien_252 { get => soThanhVien_252; set => soThanhVien_252 = value; }
        public int SoNha_252 { get => soNha_252; set => soNha_252 = value; }
        internal Nguoi[] Tv_252 { get => tv_252; set => tv_252 = value; }

        public HoGiaDinh()
        {

        }

        public HoGiaDinh(int soThanhVien_252, int soNha_252, Nguoi[] tv_252)
        {
            this.soThanhVien_252 = soThanhVien_252;
            this.soNha_252 = soNha_252;
            this.tv_252 = tv_252;
        }

        public void NhapHoGiaDinh()
        {
            Console.WriteLine("Nhap so thanh vien: ");
            soThanhVien_252 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so nha: ");
            soNha_252 = int.Parse(Console.ReadLine());
            for (int i_252 = 1; i_252 <= soThanhVien_252; i_252++)
            {
                Console.WriteLine("Nhap so thanh vien thu " + i_252);
                tv_252[i_252] = new Nguoi();
                tv_252[i_252].NhapThongTinNguoi();
            }
        }
        public void InThongTinHoGiaDinh()
        {
            Console.WriteLine("So thanh vien: {0}, So nha: {1}", soThanhVien_252, soNha_252);
            for (int i_252 = 1; i_252 <= soThanhVien_252; i_252++)
            {
                Console.WriteLine("Thanh vien thu " + i_252);
                tv_252[i_252].InThongTinNguoi();
            }
        }
    }
}
