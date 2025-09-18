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

            Employee per = new Employee();
            Console.WriteLine("Nhập thông tin nhân viên thu ngân: ");
            per.Nhap();
            Console.WriteLine();
            Console.WriteLine("Thông tin nhân viên thu ngân:");
            Console.WriteLine(per.ToString());
            Console.WriteLine();

            DiscountBill discountBill = new DiscountBill(per, true);
            GroceryBill groceryBill = new GroceryBill(per);
            //bill1.addItem(new Item(1, "KitKat Chocolate", 1.35, 0.5));
            //bill1.addItem(new Item(2, "Coca-Cola 330ml", 0.99, 0.25));
            //bill2.addItem(new Item(3, "Lays Chips", 2.50, 0.0));
            Console.Write("Nhập số lượng mặt hàng: ");
            int n = int.Parse(Console.ReadLine());
            //Console.WriteLine()
            //string y_n = Console.ReadLine().Trim().ToLower();
            for(int i = 0; i < n; i++)
            {
                //Console.Write("Mặt hàng này có giảm giá hay không: ");
                //bool ok = bool.Parse(Console.ReadLine());
                Console.WriteLine($"Nhập thông tin mặt hàng {i + 1}: ");
                Item it = new Item();
                it.Nhap();
                if (it.getDiscount == 0) groceryBill.addItem(it);
                else discountBill.addItem(it);
                Console.WriteLine();
            }
            Console.Clear();
            if(groceryBill != null)
            {
                groceryBill.printReceipt();
                if(discountBill != null)
                {
                    discountBill.printReceipt();
                    return;
                }
            }
            Console.WriteLine("Không có hóa đơn nào!");
            
        }
    }
}
