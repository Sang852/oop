using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    internal class DiscountBill : GroceryBill
    {
        private bool preferred;
        public DiscountBill(Employee clerk, bool preferred) : base(clerk)
        {
            this.preferred = preferred;
        }

        // Số lượng mặt hàng giảm giá
        public int getDiscountCount()
        {
            int dem = 0;
            for(int i = 0; i < cnt; i++)
            {
                if (list[i].getDiscount > 0) ++dem;
            }
            return dem;
            
        }

        // Tổng số tiền sau khi được giảm giá
        public override double getTotal()
        {
            // Nếu không phải khách hàng ưu tiên thì trả về tổng số tiền gốc
            if (!preferred)
            {
                return base.getTotal();
            }
            double sum = 0;
            for(int i = 0; i < base.cnt; i++)
            {
                 sum += list[i].getDiscountPrice(); 
            }
            return sum;
        }

        //Tổng tiền được giảm
        public double getDiscountAmount()
        {
            if (!preferred) return 0;
            double sum = 0;
            for(int i = 0; i < base.cnt; i++)
            {
                if (list[i].getDiscount > 0)
                    sum += list[i].getDiscount;
            }
            return sum;

        }

        // % giảm giá so với tổng hóa đơn gốc
        // tổng giảm giá / tổng hóa đơn gốc * 100

        public double getDiscountPercent()
        {
            return getTotal() / base.getTotal();
        }

        public override void printReceipt()
        {
            Console.WriteLine("----- Discount Bill -----");
            Console.WriteLine($"Clerk: {clerk.ID}");

            Console.WriteLine("\nItems:");
            int index = 1;
            for(int i = 0; i < base.cnt; i++)
            {
                Console.WriteLine($"{index,2}. {list[i].Name,-20} {list[i].getPrice,8:C2} - {list[i].getDiscount,8:C2} => {list[i].getDiscountPrice(),8:C2}");
                index++;
            }

            Console.WriteLine("\nOriginal Total: {0:C2}", base.getTotal());
            Console.WriteLine("Discount:       {0:C2}", getDiscountAmount());
            Console.WriteLine("You Pay:        {0:C2}", getTotal());
            Console.WriteLine("Discount %:     {0:F2} %", getDiscountPercent());
            Console.WriteLine("-------------------------\n");
        }
    }
}
