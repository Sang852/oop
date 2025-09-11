using System.Text;

namespace HW1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            string hoten, masv, lop, username, gmail;
            hoten = "Đặng Ngọc Sang";
            masv = "12424027";
            lop = "12424TN";
            username = "Sang852";
            gmail = "sangd6216@gmail.com";
            Console.WriteLine("Họ tên\t\t Mã sinh viên\t Lớp\t\t Tên tài khoản github\t Địa chỉ email");
            Console.WriteLine($"{hoten}\t {masv}\t {lop}\t {username}\t\t {gmail}");
        }
    }
}
