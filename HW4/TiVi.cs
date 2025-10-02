using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    internal class TiVi:ThietBiGiaDung
    {
        public double KichCoManHinh { get; set; }

        public TiVi() { }
        public TiVi(string nhaSanXuat, string model, double gia, double kichCoManHinh) : base(nhaSanXuat, model, gia) {
            KichCoManHinh = kichCoManHinh;
        }

        public override void Nhap()
        {
            while (true)
            {
                try
                {
                    Console.Write("Nhập nhà sản xuất: ");
                    NhaSanXuat = Console.ReadLine().Trim();
                    if (string.IsNullOrEmpty(NhaSanXuat))
                        throw new Exception("Lỗi: Tên nhà sản xuất không được để trống!");
                    if (!NhaSanXuat.All(c =>char.IsLetter(c) || char.IsWhiteSpace(c)))
                        throw new Exception("Lỗi: Tên nhà sản xuất không được chứa kí tự số hoặc kí tự đặc biệt!");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            while (true)
            {
                try
                {
                    Console.Write("Nhập model của máy giặt: ");
                    Model = Console.ReadLine().Trim();
                    if (string.IsNullOrEmpty(Model))
                        throw new Exception("Lỗi: Model không được để trống!");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            while (true)
            {
                try
                {
                    Console.Write("Nhập giá thành của tivi: ");
                    string giaThanh = Console.ReadLine().Trim();
                    double price;
                    if (string.IsNullOrEmpty(giaThanh))
                        throw new Exception("Lỗi: Giá thành của tivi không được bỏ trống!");
                    if (double.TryParse(giaThanh, out price))
                    {
                        Gia = price;
                    }
                    else throw new Exception("Lỗi: Giá thành của tivi không được chứa kí tự chữ cái hoặc kí tự đặc biệt!");

                    if (Gia <= 0)
                        throw new Exception("Lỗi:  Giá thành của tivi phải > 0!");
                    break;

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            while (true)
            {
                try
                {
                    Console.Write("Nhập kích thước màn hình của tivi: ");
                    string kichCoManHinh = Console.ReadLine().Trim();
                    double kichco;
                    if (string.IsNullOrEmpty(kichCoManHinh))
                        throw new Exception("Lỗi: Kích thước màn hình của tivi không được bỏ trống!");
                    if (double.TryParse(kichCoManHinh, out kichco))
                    {
                        KichCoManHinh = kichco;
                    }
                    else throw new Exception("Lỗi: Kích thước màn hình không được chứa kí tự chữ cái hoặc kí tự đặc biệt!");

                    if (KichCoManHinh <= 0)
                        throw new Exception("Lỗi: Trọng lượng tối đa của máy giặt phải > 0!");
                    break;

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public override string ToString()
        {
            return $"[Tivi] Hãng: {NhaSanXuat}, Model: {Model}, Giá: {Gia}, Kích cỡ màn hình: {KichCoManHinh} inch";
        }
    }
}
