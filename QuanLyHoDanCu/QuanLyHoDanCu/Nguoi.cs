using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHoDanCu
{
    class Nguoi
    {
        private string hoTen_252;
        private int tuoi_252;
        private string ngheNghiep_252;
        private int cmnd_252;

        public Nguoi() { }

        public Nguoi(string hoTen_252, int tuoi_252, string ngheNghiep_252, int cmnd_252) 
        {
            this.hoTen_252 = hoTen_252;
            this.tuoi_252 = tuoi_252;
            this.ngheNghiep_252 = ngheNghiep_252;
            this.cmnd_252 = cmnd_252;
        }

        public string HoTen_252 { get => hoTen_252; set => hoTen_252 = value; }
        public int Tuoi_252 { get => tuoi_252; set => tuoi_252 = value; }
        public string NgheNgiep_252 { get => ngheNghiep_252; set => ngheNghiep_252 = value; }
        public int Cmnd_252 { get => cmnd_252; set => cmnd_252 = value; }

        public void NhapThongTinNguoi()
        {
            Console.WriteLine("Nhap ho va ten : ");
            hoTen_252 = Console.ReadLine();
            Console.WriteLine("Nhap tuoi: ");
            tuoi_252 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap nghe nghiep:  ");
            ngheNghiep_252 = Console.ReadLine();
            Console.WriteLine("Nhap so cmnd: ");
            cmnd_252 = int.Parse(Console.ReadLine());
        }

        public void InThongTinNguoi()
        {
            Console.WriteLine("Ho ten: {0}, Tuoi: {1}, Nghe nghiep: {2}, CMND: {3}", hoTen_252, tuoi_252, ngheNghiep_252, cmnd_252);
        }
    }
}
