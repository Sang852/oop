using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    internal class Item
    {
        private int itemId;
        private string name;
        private double price; //giá gốc
        private double discount;// số tiền giảm giá trực tiếp

        public Item() { }
        public Item(int itemId, string name, double price, double discount)
        {
            this.itemId = itemId;
            this.name = name;
            this.price = price;
            this.discount = discount;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double getPrice
        {
            get { return price; }
            set
            {
                if (value <= 0)
                    price = 1;
                else price = value;
            }
        }

        public double getDiscount
        {
            get { return discount; }
            set
            {
                if (value <= 0 || value >= price)
                    discount = 1;
                else discount = value;
            }
        }


        //public void Nhap()
        //{
        //    while (true)
        //    {
        //        try
        //        {
        //            // Nhập mã hàng
        //            Console.Write("Nhập mã hàng hóa: ");
        //            itemId = int.Parse(Console.ReadLine() ?? "0");
        //            if (itemId <= 0)
        //                throw new Exception("Mã hàng phải lớn hơn 0!");

        //            // Nhập tên hàng
        //            Console.Write("Nhập tên hàng hóa: ");
        //            name = Console.ReadLine();
        //            if (string.IsNullOrWhiteSpace(name))
        //                throw new Exception("Tên hàng không được để trống!");
        //            //if (!isDigit(name))
        //            //    throw new Exception("Tên hàng không được chứa kí tự chữ số!");

        //            // Nhập giá
        //            Console.Write("Nhập giá gốc: ");
        //            price = double.Parse(Console.ReadLine() ?? "0");
        //            if (price <= 0)
        //                throw new Exception("Giá gốc phải > 0!");

        //            // Nhập giảm giá
        //            Console.Write("Nhập số tiền giảm giá: ");
        //            discount = double.Parse(Console.ReadLine() ?? "0");
        //            if (discount < 0 || discount >= price)
        //                throw new Exception("Giảm giá phải >= 0 và < giá gốc!");

        //            // Nếu đến đây thì tất cả hợp lệ
        //            break;
        //        }
        //        catch (FormatException)
        //        {
        //            Console.WriteLine("Sai định dạng! Vui lòng nhập lại.");
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine(ex.Message);
        //        }
        //    }
        //}

        public void Nhap()
        {
            while (true)
            {
                try
                {
                    Console.Write("Nhập mã mặt hàng: ");
                    string item_id = Console.ReadLine();
                    if (string.IsNullOrEmpty(item_id))
                        throw new Exception("Mã mặt hàng không được để trống!");
                    if (!int.TryParse(item_id, out itemId))
                        throw new Exception("Mã mặt hàng phải là số nguyên!");
                    if (itemId <= 0)
                        throw new Exception("Mã mặt hàng phải là số nguyên dương!");
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
                    Console.Write("Nhập tên mặt hàng: ");
                    name = Console.ReadLine();
                    if (string.IsNullOrEmpty(name))
                        throw new Exception("Tên hàng hóa không được để trống!");
                    if (!isNotDigit(name))
                        throw new Exception("Tên hàng hóa không được chứa số!");
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
                    Console.Write("Nhập giá gốc: ");
                    string Price = Console.ReadLine();
                    if (string.IsNullOrEmpty(Price))
                        throw new Exception("Giá gốc hàng hóa không được để trống!");
                    if (!double.TryParse(Price, out price))
                        throw new Exception("Giá gốc phải là số thực!");
                    if (price <= 0)
                        throw new Exception("Giá gốc hàng hóa > 0!");
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
                    Console.Write("Nhập giá giảm giá: ");
                    string Discount = Console.ReadLine();
                    if (string.IsNullOrEmpty(Discount))
                        throw new Exception("Giá giảm giá mặt hàng không được để trống!");
                    if (!double.TryParse(Discount, out discount))
                        throw new Exception("Giá giảm giá phải phải là số!");
                    if (discount < 0 || discount >= price)
                        throw new Exception("Giá giảm giá >= 0 và < giá gốc");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private bool isNotDigit(string x)
        {
            if (x == null) return false;
            for(int i = 0; i < x.Length; i++)
            {
                if (char.IsDigit(x[i])) return false;
            }
            return true;
        }


        public double getDiscountPrice()
        {
            return price - discount;
        }

        public override string ToString()
        {
            if(discount > 0)
                return $"Mã hàng hóa: {itemId}, Tên hàng hóa: {name}, Giá gốc: {price}, Giá giảm trực tiếp: {discount}";
            return $"Mã hàng hóa: {itemId}, Tên hàng hóa: {name}, Giá gốc: {price}";
        }


    }
}
