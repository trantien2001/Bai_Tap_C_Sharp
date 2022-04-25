using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class KySu : CanBo
    {
        public KySu()
        {
            Ten_252 = "tien";
            Tuoi_252 = 20;
            GioiTinh_252 = "Nam";
            DiaChi_252 = "Ha Tinh";
        }
        public KySu(string ten_252, int tuoi_252, string gioitinh_252, string diachi_252) :
            base(ten_252, tuoi_252, gioitinh_252, diachi_252)
        { }
    }
}
