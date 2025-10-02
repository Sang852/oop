using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    internal class MayLanh : ThietBiGiaDung
    {
        public double MaLuc { get; set; }// Mã lực

        public MayLanh() : base() { }
        public MayLanh(string nhaSanXuat, string model, double gia, double maLuc):base(nhaSanXuat, model, gia)
        {
            MaLuc = maLuc;
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
                    if (!NhaSanXuat.All(c => char.IsLetter(c)||char.IsWhiteSpace(c)))
                        throw new Exception("Lỗi: Tên nhà sản xuất không được chứa kí tự số hoặc kí tự đặc biệt!");
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
                    Console.Write("Nhập model của máy lạnh: ");
                    Model = Console.ReadLine().Trim();
                    if (string.IsNullOrEmpty(Model))
                        throw new Exception("Lỗi: Model không được để trống!");
                    break;
                }catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            while (true)
            {
                try
                {
                    Console.Write("Nhập giá thành của máy lạnh: ");
                    string giaThanh = Console.ReadLine().Trim();
                    double price;
                    if (string.IsNullOrEmpty(giaThanh))
                        throw new Exception("Lỗi: Giá thành của máy lạnh không được bỏ trống!");
                    if (double.TryParse(giaThanh, out price))
                    {
                        Gia = price;
                    }
                    else throw new Exception("Lỗi: Giá thành của máy lạnh không được chứa kí tự chữ cái hoặc kí tự đặc biệt!");

                    if (Gia <= 0)
                        throw new Exception("Lỗi:  Giá thành của máy lạnh phải > 0!");
                    break;
                        
                }catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            while (true)
            {
                try
                {
                    Console.Write("Nhập mã lực của máy lạnh: ");
                    string maLuc = Console.ReadLine().Trim();
                    double maluc;
                    if (string.IsNullOrEmpty(maLuc))
                        throw new Exception("Lỗi: Mã lực của máy lạnh không được bỏ trống!");
                    if (double.TryParse(maLuc, out maluc))
                    {
                        MaLuc = maluc;
                    }
                    else throw new Exception("Lỗi: Mã lực của máy lạnh không được chứa kí tự chữ cái hoặc kí tự đặc biệt!");

                    if (MaLuc <= 0)
                        throw new Exception("Lỗi:  Mã lực của máy lạnh phải > 0!");
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
            return $"[Máy lạnh] Hãng: {NhaSanXuat}, Model: {Model}, Giá: {Gia}, Mã lực: {MaLuc}";
        }
    }
}
