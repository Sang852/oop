using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    internal class Person
    {
        private string name;
        private string address;
        private double salary;

        public Person()
        {
            name = "";
            address = "";
            salary = 0;
        }
        public Person(string name, string address, double salary)
        {
            this.name = name;
            this.address = address;
            this.salary = salary;
        }

        public string Name
        {
            get { 
                return name; 
            }
            set
            {
                name = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }
        public double Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }
        public Person inputPersonInfo()
        {
            while (true)
            {
                try
                {
                    Console.Write("Please input name: ");
                    name = Console.ReadLine();
                    if (string.IsNullOrEmpty(name))
                        throw new Exception("You must input Name.");
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
                    Console.Write("Please input address: ");
                    address = Console.ReadLine();
                    if (string.IsNullOrEmpty(address))
                        throw new Exception("You must input Name.");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            

            string sSalary;
            double salary;
            while (true)
            {
                try
                {
                    Console.Write("Please input salary: ");
                    sSalary = Console.ReadLine();
                    if (string.IsNullOrEmpty(sSalary))
                        throw new Exception("You must input Salary.");
                    if (!double.TryParse(sSalary, out salary))
                        throw new Exception("You must input digit.");
                    if (salary <= 0)
                        throw new Exception("Salary is greater than zero.");
                    break;

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

            return new Person(name, address, salary);
        }

        public void displayPersonInfo(Person person)
        {
            Console.WriteLine("Information of Person you have entered: ");
            Console.WriteLine($"Name: {person.name}");
            Console.WriteLine($"Address: {person.address}");
            Console.WriteLine($"Salary: {person.salary}");
            Console.WriteLine();
        }

        public Person[] sortBySalary(Person[] persons)
        {
            if (persons.Length == 0 || persons == null)
            {
                throw new Exception("Can't Sort Person");
            }
            for (int i = 0; i < persons.Length - 1; i++)
            {
                for (int j = 0; j < persons.Length - i - 1; j++)
                {
                    if (persons[j].salary > persons[j + 1].salary)
                    {
                        Person tmp = persons[j];
                        persons[j] = persons[j + 1];
                        persons[j + 1] = tmp;
                    }
                }
            }
            return persons;
        }
    }
}
