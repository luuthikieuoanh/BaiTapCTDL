using System;
using System.Collections.Generic;
using System.Text;

namespace BT4_C5
{
    class HangHoa
    {
        //Fields
        private string _maHang;
        private string _tenHang;
        private int _soLuong;
        private int _donGia;
        private static int _id = 0;

        //Properties

        public string MaHang { get => _maHang; private set => _maHang = value; }
        public string TenHang { get => _tenHang; set => _tenHang = value; }
        public int SoLuong { get => _soLuong; set => _soLuong = value; }
        public int DonGia { get => _donGia; set => _donGia = value; }
        public static int Id { get => _id; set => _id = value; }

        //Constructors
        public HangHoa(string tenhang, int soluong, int dongia)
        {
            this._tenHang = tenhang;
            this._soLuong = soluong;
            this._donGia = dongia;
            this._maHang = "HH" + _id.ToString("0000");
            _id++;
        }

        //Methods
        //Display
        public void Display()
        {
            Console.WriteLine("{0,-15} {1}","Ma Hang", MaHang);
            Console.WriteLine("{0,-15} {1}", "Ten Hang", TenHang);
            Console.WriteLine("{0,-15} {1:#,#,#}", "So Luong", SoLuong);
            Console.WriteLine("{0,-15} {1:#,#,#}", "Don Gia", DonGia);
            Console.WriteLine("-------------------------");
        }
    }
}
