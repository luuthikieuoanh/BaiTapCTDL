using System;
using System.Collections.Generic;
using System.Text;

namespace C4_BT6
{
    class PhanTuDaThuc
    {
        public int heso;
        public int somu;

        public PhanTuDaThuc()
        {
            this.heso = 0;
            this.somu = 0;
        }

        public PhanTuDaThuc(int heso, int somu)
        {
            this.heso = heso;
            this.somu = somu;
        }

        //Methods
        //Nhập phần tử đa thức
        public void NhapPTDaThuc(int somu)
        {
            Console.Write("Nhap he so: ");
            int.TryParse(Console.ReadLine(), out this.heso);
            this.somu = somu;
        }

        //Xuất phần tử đa thức
        public string XuatPTDaThuc()
        {
            return $"{this.heso}*X^{this.somu}";
        }
    }
}
