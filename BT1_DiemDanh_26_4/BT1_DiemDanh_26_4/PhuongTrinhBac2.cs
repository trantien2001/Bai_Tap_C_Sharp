using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1_DiemDanh_26_4
{
    class PhuongTrinhBac2
    {
        private double a_252;
        private double b_252;
        private double c_252;
        public PhuongTrinhBac2() { }
        public PhuongTrinhBac2(double a_252, double b_252, double c_252)
        {
            this.a_252 = a_252;
            this.b_252 = b_252;
            this.c_252 = c_252;
        }

        public double A_252 { get => a_252; set => a_252 = value; }
        public double B_252 { get => b_252; set => b_252 = value; }
        public double C_252 { get => c_252; set => c_252 = value; }
        public double Delta(double a_252, double b_252, double c_252)
        {
            double delta_252 = b_252 * b_252 - 4 * a_252 * c_252;
            return delta_252;
        }
        public void Nghiem(double a_252, double b_252, double c_252) 
        {
            double x1_252, x2_252;
            x1_252 = (- b_252 - Math.Sqrt(Delta(a_252, b_252, c_252))) / (2 * a_252);
            x2_252 = (- b_252 + Math.Sqrt(Delta(a_252, b_252, c_252))) / (2 * a_252);
            Console.WriteLine("Nghiem cua phuong trinh la: x1 = " + x1_252 + ", x2 = " + x2_252);
        }

    }
}
