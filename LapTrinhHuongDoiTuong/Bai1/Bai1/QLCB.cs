using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class QLCB
    {
        //public List<CanBo> ListCanBo_252 = null;
        public List<CanBo> ListCanBo_252 = new List<CanBo>();

        public void ThemCanBo()
        {
            CanBo cb = new CanBo();
            
            Console.Write("Nhap ten can bo: ");
            cb.Ten_252 = (Console.ReadLine());
            
            Console.Write("Nhap tuoi can bo: ");
            cb.Tuoi_252 = int.Parse(Console.ReadLine());
            
            Console.Write("Nhap gioi tinh: ");
            cb.GioiTinh_252 = (Console.ReadLine());
            
            Console.Write("Nhap dia chi: ");
            cb.DiaChi_252 = (Console.ReadLine());

            ListCanBo_252.Add(cb);
        }
        public List<CanBo> TimKiemTheoTen()
        {
            string ten_252;
            Console.Write("Nhap ten can tim: ");
            ten_252 = Console.ReadLine();
            List<CanBo> tk_252 = new List<CanBo>();
            if(ListCanBo_252 != null)
            {
                foreach(CanBo cb in ListCanBo_252)
                {
                    if (cb.Ten_252.ToUpper().Contains(ten_252.ToUpper()))
                    {
                        tk_252.Add(cb);
                    }
                }
            }
            return tk_252;
        }
        public void HienThiDanhSach(List<CanBo> ListCanBo)
        {
            Console.WriteLine("{0} {1} {2} {3}", "Ten_252", "Tuoi_252", "DiaChi_252", "GioiTinh_252");
            if(ListCanBo != null)
            {
                foreach(CanBo cb in ListCanBo)
                {
                    Console.WriteLine("{0} {1} {2} {3}", cb.Ten_252, cb.Tuoi_252, cb.GioiTinh_252, cb.DiaChi_252);
                }
            }
            Console.WriteLine();
        }
        public List<CanBo> getListCanBo()
        {
            return ListCanBo_252;
        }
    }
}
