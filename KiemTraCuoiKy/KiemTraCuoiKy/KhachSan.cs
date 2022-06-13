using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTraCuoiKy
{
    class KhachSan
    {
        private int soNgayThue_252;
        private string loaiPhong_252;
        private double giaPhong_252;
        private Nguoi nguoi_252;
        public KhachSan() {}
        public KhachSan(int soNgayThue_252, string loaiPhong_252, Nguoi nguoi_252)
        {
            this.soNgayThue_252 = soNgayThue_252;
            this.loaiPhong_252 = loaiPhong_252;
            this.nguoi_252 = nguoi_252;
        }

        public int SoNgayThue_252 { get => soNgayThue_252; set => soNgayThue_252 = value; }
        public string LoaiPhong_252 { get => loaiPhong_252; set => loaiPhong_252 = value; }
        internal Nguoi Nguoi { get => nguoi_252; set => nguoi_252 = value; }
        public void nhapThongTinCanQuanLy()
        {
            nguoi_252 = new Nguoi();
            nguoi_252.NhapThongTinNguoi();
            Console.WriteLine("Nhap so ngay thue: ");
            soNgayThue_252 = int.Parse(Console.ReadLine());
            do {
                Console.WriteLine("Nhap loai phong: ");
                loaiPhong_252 =  Console.ReadLine();
                Console.WriteLine(loaiPhong_252);
            } while (String.Compare(loaiPhong_252, "A", true) != 0 
                && String.Compare(loaiPhong_252, "B", true) != 0 
                && String.Compare(loaiPhong_252, "C", true) != 0);
            switch (loaiPhong_252.ToUpper())
            {
                case "A":
                    giaPhong_252 = 500;
                    break;
                case "B":
                    giaPhong_252 = 300;
                    break;
                case "C":
                    giaPhong_252 = 100;
                    break;
            }
        }
        public void hienThiThongTinCanQuanLy()
        {
            nguoi_252.InThongTinNguoi();
            Console.WriteLine("So ngay thue: " + soNgayThue_252);
            Console.WriteLine("Loai phong: " + loaiPhong_252);
            Console.WriteLine("Gia phong: " + giaPhong_252);
        }
        public double tinhTienThue()
        {
            return soNgayThue_252 * giaPhong_252;
        }
    }
}
