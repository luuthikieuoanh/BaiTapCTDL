using System;
using System.Collections.Generic;
using System.Text;

namespace BT3_C4
{
    class SinhVien
    {
        //Fields
        private string _maSV;
        private string _hoten;
        private string _lop;
        private DateTime _ngaysinh;
        private double _diemTB;
        private static int _id = 0;


        //Properties
        public string MaSV { get => _maSV; protected  set => _hoten = value; }
        public string Hoten { get => _hoten; set => _hoten = value; }
        public string Lop { get => _lop; set => _lop = value; }
        public DateTime Ngaysinh { get => _ngaysinh; set => _ngaysinh = value; }
        public double DiemTB
        {
            get => _diemTB;
            set
            {
                _diemTB = value;
                if (value < 0 || value > 10)
                {
                    _diemTB = 0;
                }
            }
        }
        public static int Id { get => _id; }

        //Constructor
        public SinhVien()
        {
            this._hoten = null;
            this._lop = null;
            this.Ngaysinh = new DateTime(1990, 1, 1);
            this._diemTB = 0;
            this._maSV = null;
        }

        public SinhVien(string hoten, string lop, DateTime ngaysinh, double diem)
        {
            this.Hoten = hoten;
            this.Lop = lop;
            this.Ngaysinh = ngaysinh;
            this.DiemTB = diem;
            
            if (DiemTB < 0 || DiemTB > 10)
            {
                DiemTB = 0;
            }
            this._maSV = "19211TT" + _id.ToString("0000");
            _id++;
        }

        //Methods
        //Print
        public void Print()
        {
            Console.WriteLine("{0,-20} : {1}","Ma Sinh vien",this._maSV);
            Console.WriteLine("{0,-20} : {1}", "Ho ten", this._hoten);
            Console.WriteLine("{0,-20} : {1}", "Lop", this._lop);
            Console.WriteLine("{0,-20} : {1:dd/MM/yyyy}", "Ngay sinh", this._ngaysinh);
            Console.WriteLine("{0,-20} : {1:#.00}", "Diem trung binh", this._diemTB);
            Console.WriteLine("----------------------------");
        }

        //Nhập dữ liệu
        public SinhVien NhapDLSV()
        {

            Console.Write("Nhap ten sinh vien: ");
            string hoten = Console.ReadLine();
            Console.Write("Nhap ten lop: ");
            string lop = Console.ReadLine();
            Console.Write("Nhap ngay sinh: ");
            DateTime.TryParse(Console.ReadLine(), out DateTime ngaysinh);
            Console.Write("Nhap diem trung binh: ");
            double.TryParse(Console.ReadLine(), out double diemTB);

            Console.WriteLine();
            Console.WriteLine("----------------------------");
            return new SinhVien(hoten, lop, ngaysinh, diemTB);
        }


    }
}
