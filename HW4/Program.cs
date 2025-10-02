using System.Text;
using System.Xml.Serialization;

namespace HW4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            List<ThietBiGiaDung> list = new List<ThietBiGiaDung>();
            while (true)
            {
                Console.WriteLine("----- MENU ------");
                Console.WriteLine("1. Nhập máy lạnh");
                Console.WriteLine("2. Nhập máy giặt");
                Console.WriteLine("3. Nhập tivi");
                Console.WriteLine("4. Xuất toàn bộ thiết bị");
                Console.WriteLine("5. Xuất danh sách theo loại");
                Console.WriteLine("6. Xuất danh sách theo nhà sản xuất");
                Console.WriteLine("0. Thoát");
                int choice;
                while (true)
                {
                    try
                    {
                        Console.Write("Nhập lựa chọn: ");
                        string chon = Console.ReadLine().Trim();
                        if (string.IsNullOrEmpty(chon))
                            throw new Exception("Lỗi: Lựa chọn không được để trống!");
                        if (!int.TryParse(chon, out choice))
                            throw new Exception("Lỗi: Lựa chọn không được chứa kí tự chữ cái!");
                        if (choice < 0 || choice > 6)
                            throw new Exception("Lỗi: Lựa chọn không hợp lệ (1-6)!");
                        break;
                    }catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                

                if (choice == 0) break;

                switch (choice)
                {
                    case 1:
                        MayLanh ac = new MayLanh();
                        ac.Nhap();
                        list.Add(ac);
                        break;
                    case 2:
                        MayGiat wm = new MayGiat();
                        wm.Nhap();
                        list.Add(wm);
                        break;
                    case 3:
                        TiVi tv = new TiVi();
                        tv.Nhap();
                        list.Add(tv);
                        break;
                    case 4:
                        Console.WriteLine("\n--- Danh sách toàn bộ thiết bị ---");
                        foreach (var item in list) Console.WriteLine(item);
                        break;
                    case 5:
                        Console.WriteLine("Chọn loại: 1.Máy lạnh  2.Máy giặt  3.Tivi");
                        int type = int.Parse(Console.ReadLine());
                        foreach (var item in list)
                        {
                            if ((type == 1 && item is MayLanh) ||
                                (type == 2 && item is MayGiat) ||
                                (type == 3 && item is TiVi))
                            {
                                Console.WriteLine(item);
                            }
                        }
                        break;
                    case 6:
                        Console.Write("Nhập tên nhà sản xuất cần tìm: ");
                        string prod = Console.ReadLine();
                        foreach (var item in list.Where(x => x.NhaSanXuat == prod))
                            Console.WriteLine(item);
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }
            }
        }
    }
}
