using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    public class CanBo
    {
        //private List<CanBo> ListCanBo = null;
        private string ten_252;
        private int tuoi_252;
        private string gioiTinh_252;
        private string diaChi_252;
        
        public CanBo() { }

        public string Ten_252 { get => ten_252; set => ten_252 = value; }
        public int Tuoi_252 { get => tuoi_252; set => tuoi_252 = value; }
        public string GioiTinh_252 { get => gioiTinh_252; set => gioiTinh_252 = value; }
        public string DiaChi_252 { get => diaChi_252; set => diaChi_252 = value; }

        public CanBo(string ten_252, int tuoi_252, string gioiTinh_252, string diaChi_252)
        {
            Ten_252 = ten_252;
            Tuoi_252 = tuoi_252;
            GioiTinh_252 = gioiTinh_252;
            DiaChi_252 = diaChi_252;
        }
    }
}
