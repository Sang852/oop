using System;
using System.Text;
namespace HW2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            
            int n;
            Person[] persons;
            while (true)
            {
               try
               {
                    Console.Write("Enter the number of people: ");
                    string num = Console.ReadLine();
                    if (string.IsNullOrEmpty(num))
                        throw new Exception("You cannot leave blank.");
                    if (!int.TryParse(num, out n))
                        throw new Exception("You must input digit.");
                    if (n <= 0)
                        throw new Exception("Number of people must be positive integer.");
                    persons = new Person[n];
                    break;
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.Write("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
            Person person = new Person();

            Console.WriteLine("=====Management Person Program=====");

            // Nhập 3 người
            for (int i = 0; i < persons.Length; i++)
            {
                Console.WriteLine("Input Information of Person");
                persons[i] = person.inputPersonInfo();
            }

            // Sắp xếp
            try
            {
                persons = person.sortBySalary(persons);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            Console.WriteLine();
            foreach (Person p in persons)
            {
                person.displayPersonInfo(p);
            }
        }
    }
}
