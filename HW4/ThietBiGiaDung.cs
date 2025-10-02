using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    abstract class ThietBiGiaDung
    {
        public string NhaSanXuat { get; set; }// Nhà sản xuất
        public string Model { get; set; }
        public double Gia { get; set; }// giá thành

        public ThietBiGiaDung()
        {
            NhaSanXuat = "NO_NAME";
            Model = "NO_NAME";
            Gia = 0;
        }
        public ThietBiGiaDung(string nhaSanXuat, string model, double gia)
        {
            NhaSanXuat = nhaSanXuat;
            Model = model;
            Gia = gia;
        }

        public abstract void Nhap();
        public abstract override string ToString();
    }
}
