using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    internal class MayGiat: ThietBiGiaDung
    {
        public double TrongLuong { get; set; }

        public MayGiat() : base() { }
        public MayGiat(string nhaSanXuat, string model, double gia, double trongLuong):base(nhaSanXuat, model, gia)
        {
            TrongLuong = trongLuong;
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
                    if (!NhaSanXuat.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
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
                    Console.Write("Nhập giá thành của máy giặt: ");
                    string giaThanh = Console.ReadLine().Trim();
                    double price;
                    if (string.IsNullOrEmpty(giaThanh))
                        throw new Exception("Lỗi: Giá thành của máy giặt không được bỏ trống!");
                    if (double.TryParse(giaThanh, out price))
                    {
                        Gia = price;
                    }
                    else throw new Exception("Lỗi: Giá thành của máy giặt không được chứa kí tự chữ cái hoặc kí tự đặc biệt!");

                    if (Gia <= 0)
                        throw new Exception("Lỗi:  Giá thành của máy giặt phải > 0!");
                    break;

                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            while (true)
            {
                try
                {
                    Console.Write("Nhập trọng lượng tối đa của máy giặt: ");
                    string trongLuong = Console.ReadLine().Trim();
                    double tronluong;
                    if (string.IsNullOrEmpty(trongLuong))
                        throw new Exception("Lỗi: Trọng lượng tối đa của máy giặt không được bỏ trống!");
                    if (double.TryParse(trongLuong, out tronluong))
                    {
                        TrongLuong = tronluong;
                    }
                    else throw new Exception("Lỗi: Trọng lượng tối đa của máy giặt không được chứa kí tự chữ cái hoặc kí tự đặc biệt!");

                    if (TrongLuong <= 0)
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
            return $"[Máy giặt] Hãng: {NhaSanXuat}, Model: {Model}, Giá: {Gia}, Trọng lượng tối đa: {TrongLuong}kg";
        }
    }
}
