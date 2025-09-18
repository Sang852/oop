using System;
using System.Text;
namespace HW3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            
            // Nhập thông tin nhân viên
            Employee per = new Employee();
            Console.WriteLine("Nhập thông tin nhân viên thu ngân: ");
            per.Nhap();
            Console.WriteLine();
            Console.WriteLine("Thông tin nhân viên thu ngân:");
            Console.WriteLine(per.ToString());
            Console.WriteLine();



            bool preferred;
            while (true)
            {
                Console.Write("Khách hàng có phải là khách ưu tiên không? (y/n): ");
                string ok = Console.ReadLine().Trim().ToLower();
                if (ok == "y" || ok == "yes" || ok == "Yes") {
                    preferred = true;
                    break;
                }
                else if (ok == "n" || ok == "no" || ok == "No")
                {
                    preferred = false;
                    break;
                }
                
            }
            // Kế thừa
            // Theo nguyên tắc is-a thì DiscountBill là một loại của GroceryBill
            // Có thể gán một đối tượng ở lớp dẫn xuất DiscountBill cho biến tham chiếu kiểu lớp cơ sở GroceryBill

            // Đa hình
            //Nếu bill thực sự là DiscountBill, thì gọi bill.GetTotal() sẽ chạy phiên bản override của DiscountBill.
            //Nếu bill thực sự là GroceryBill, thì chạy phiên bản gốc.
            GroceryBill bill;
            if (preferred)
                bill = new DiscountBill(per, true);
            else
                bill = new GroceryBill(per);
            //bill1.addItem(new Item(1, "KitKat Chocolate", 1.35, 0.5));
            //bill1.addItem(new Item(2, "Coca-Cola 330ml", 0.99, 0.25));
            //bill2.addItem(new Item(3, "Lays Chips", 2.50, 0.0));
            int n;
            while (true)
            {
                
                try
                {
                    Console.Write("Nhập số lượng mặt hàng: ");
                    string sl = Console.ReadLine();
                    if (string.IsNullOrEmpty(sl))
                        throw new Exception("Số lượng mặt hàng không được để trống");
                    if (!int.TryParse(sl, out n))
                        throw new Exception("Số lượng mặt hàng phải là số nguyên!");
                    if (n < 0)
                        throw new Exception("Số lượng mặt hàng >= 0");
                    break;
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            if(n == 0)
            {
                Console.WriteLine("Không có hóa đơn nào!");
                return;
            }
            
            
            for(int i = 0; i < n; i++)
            {
                // Nhập thông tin mặt hàng
                Console.WriteLine($"Nhập thông tin mặt hàng {i + 1}: ");
                Item it = new Item();
                it.Nhap();
                bill.addItem(it);
                Console.WriteLine();
            }
            Console.Clear();
            
            //Hiển thị hóa đơn
            bill.printReceipt();

        }
    }
}
