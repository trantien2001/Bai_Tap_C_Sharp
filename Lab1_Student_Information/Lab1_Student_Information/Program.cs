using System;

namespace Lab1_Student_Information
{
    class Student
    {
        private int SID;
        private string TenSV;
        private string Khoa;
        private float DiemTB;

        public Student()
        {
            SID = 1;
            TenSV = "Trần Y Tiến";
            Khoa = "CNTT";
            DiemTB = 8;
        }
        public Student(Student stu)
        {
            SID = stu.SID;
            TenSV = stu.TenSV;
            Khoa = stu.Khoa;
            DiemTB = stu.DiemTB;
        }

        public int SID1 { get => SID; set => SID = value; }
        public string TenSV1 { get => TenSV; set => TenSV = value; }
        public string Khoa1 { get => Khoa; set => Khoa = value; }
        public float DiemTB1 { get => DiemTB; set => DiemTB = value; }

        public void Show()
        {
            Console.WriteLine("MSSV: {0}", this.SID);
            Console.WriteLine("Ten SV: {0}", this.TenSV);
            Console.WriteLine("Khoa: {0}", this.Khoa);
            Console.WriteLine("Diem TB: {0}", this.DiemTB);
            Console.Write(Environment.NewLine);
        }

    }

    class Tester
    {
        public static void Nhap1SV(Student[] DSSV, int n)
        {
            for (int i = 0; i < n; i++)
            {
                DSSV[i] = new Student();
                Console.Write("Nhap MaSV {0}: ", i + 1);
                DSSV[i].SID1 = int.Parse(Console.ReadLine());
                Console.Write("Ho ten SV: ");
                DSSV[i].TenSV1 = Console.ReadLine();
                Console.Write("Nhap khoa: ");
                DSSV[i].Khoa1 = Console.ReadLine();
                Console.Write("Nhap Diem TB: ");
                DSSV[i].DiemTB1 = float.Parse(Console.ReadLine());
                Console.Write(Environment.NewLine);
            }
        }
        public static void XuatDS(Student[] DSSV)
        {
            foreach (Student sv in DSSV)
                sv.Show();
        }
        public static void Main()
        {
            Student[] DSSV;
            int n;
            Console.Write("Nhap so luong sinh vien: ");
            n = int.Parse(Console.ReadLine());
            DSSV = new Student[n];
            Console.WriteLine("\n === NHAP DANH SACH SINH VIEN ===");
            Nhap1SV(DSSV, n);
            Console.WriteLine("\n ====XUAT DS SINH VIEN====");
            XuatDS(DSSV);
            Console.ReadLine();
        }
    }
}
