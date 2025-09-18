using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    // Quản lý danh sách mặt hàng mua trong siêu thị
    internal class GroceryBill
    {
        protected Employee clerk;
        protected Item[] list;
        protected int n = 100; // số lượng ảo
        protected int cnt; // số lượng mặt hàng thực tế
        public GroceryBill(Employee clerk)
        {
            this.clerk = clerk;
            list = new Item[n];
        }

        public void addItem(Item i)
        {
            if(cnt == n)
            {
                Console.WriteLine("Danh sách mặt hàng đã đầy! Không thể thêm hàng!");
                return;
            }
            list[cnt++] = i;
        }

        public virtual double getTotal()
        {
            // Kiểm tra xem thực tế có mặt hàng nào được thêm vào danh sách chưa
            // Nếu chưa thì ném ra lỗi
            if(cnt == 0)
            {
                throw new Exception("Danh sách mặt hàng rỗng!");
            }
            double sum = 0;
            for (int i = 0; i < cnt; i++)
                sum += list[i].getPrice;
            return sum;
        }

        // Phương thức ảo để khi lớp DiscountBill kế thừa ghi đè phương thức thì không gây lỗi
        public virtual void printReceipt()
        {
            Console.WriteLine("----- Grocery Bill -----");
            Console.WriteLine($"Clerk: {clerk.ID}");
            Console.WriteLine("\nItems:");
            int index = 1;
            for(int i = 0; i < cnt; i++)
            {
                Console.WriteLine($"{index,2}. {list[i].Name,-20} {list[i].getPrice,8:C2}");
                index++;
            }
            Console.WriteLine("\nTotal: {0:C2}", getTotal());
            Console.WriteLine("------------------------\n");
        }
    }
}
