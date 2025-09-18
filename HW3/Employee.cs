using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    internal class Employee
    {
        private string id;
        private string hoTen;
        private string gioiTinh;

        public Employee()
        {
            id = "";
            hoTen = "";
            gioiTinh = "Nam";
        }

        public Employee(string id, string hoTen, string gioiTinh)
        {
            this.id = id;
            this.hoTen = hoTen;
            this.gioiTinh = gioiTinh;
        }

        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }

        public void Nhap()
        {
            while (true)
            {
                try
                {
                    Console.Write("Nhập mã nhân viên: ");
                    id = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(id))
                        throw new Exception("Mã nhân viên không được để trống!");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            // Nhập họ tên
            while (true)
            {
                try
                {
                    Console.Write("Nhập họ tên: ");
                    hoTen = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(hoTen))
                        throw new Exception("Họ tên không được để trống!");
                    if (hoTen.Any(char.IsDigit))
                        throw new Exception("Họ tên không được chứa số!");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            // Nhập giới tính
            while (true)
            {
                try
                {
                    Console.Write("Nhập giới tính (Nam/Nữ): ");
                    gioiTinh = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(gioiTinh))
                        throw new Exception("Giới tính không được để trống!");
                    if (gioiTinh.Any(char.IsDigit))
                        throw new Exception("Giới tính không được chứa số!");

                    // Chuẩn hóa chữ cái đầu
                    gioiTinh = gioiTinh.Trim().ToLower();
                    if (gioiTinh != "nam" && gioiTinh != "nữ" && gioiTinh != "nu")
                        throw new Exception("Giới tính chỉ được nhập Nam hoặc Nữ!");

                    gioiTinh = char.ToUpper(gioiTinh[0]) + gioiTinh.Substring(1);
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
            return $"Mã nhân viên: {id}, Họ tên: {hoTen}, Giới tính: {gioiTinh}";
        }
    }
}
