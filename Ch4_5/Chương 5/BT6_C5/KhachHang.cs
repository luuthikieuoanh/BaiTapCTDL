using System;
using System.Collections.Generic;
using System.Text;

namespace BT6_C5
{
    class KhachHang
    {
        //Fields
        private int _soGhe;
        private string _tenKH;


        //Properties
        public int SoGhe { get => _soGhe; set => _soGhe = value; }
        public string TenKH { get => _tenKH; set => _tenKH = value; }

        //Constructors
        public KhachHang(int soghe, string tenKH)
        {
            this._soGhe = soghe;
            this._tenKH = tenKH;
        }


    }
}
