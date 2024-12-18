using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Tasks
{
    enum Gender
    {
        Male,
        Female
    };

    struct HiringDate
    {
        private int day;
        private int month;
        private int year;

        public HiringDate(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public string GetDate()
        {
            return $"{day}/{month}/{year}";
        }

    }

    struct Employee
    {
        private int Id;
        private string Name;
        private int salary;
        private HiringDate hiringDate;
        private Gender gender;

        public Employee(int _id, string _name, int _salary, HiringDate _hiringDate, Gender _gender)
        {
            Id = _id;
            Name = _name;
            salary = _salary;
            hiringDate = _hiringDate;
            gender = _gender;
        }

        public void SetID(int _id)
        {
            Id = _id;
        }

        public void SetName(string _name)
        {
            Name = _name;
        }

        public void SetSalary(int _salary)
        {
            salary = _salary;
        }

        public void SetHiringDate(HiringDate _hiringDate)
        {
            hiringDate = _hiringDate;
        }

        public void SetGender(Gender _gender)
        {
            gender = _gender;
        }

        public override string ToString()
        {
            return $"Id:{Id} \nName:{Name} \n gender:{gender.ToString("D")} \n Salary:{salary} \n Employee Since: {hiringDate.GetDate()}";
        }


    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Employee[] employees = new Employee[3];

            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine($"Employee {i + 1} Data:");

                employees[i].SetID(i);

                Console.WriteLine($"Employee {i + 1} Name:");
                employees[i].SetName(Console.ReadLine());

                Console.WriteLine($"Employee {i + 1} Salary:");
                employees[i].SetSalary(Convert.ToInt32(Console.ReadLine()));

                Console.WriteLine($"Employee {i + 1} Gender F / M:");
                string op = Console.ReadLine();
                switch (op)
                {
                    case "f":
                    case "F":
                        employees[i].SetGender(Gender.Female);
                        break;
                    case "m":
                    case "M":
                        employees[i].SetGender(Gender.Male);
                        break;
                    default:
                        employees[i].SetGender(Gender.Male);
                        break;
                }

                Console.WriteLine($"Employee {i + 1} HiringDate :");

                int d, m, y;

                Console.Write($"Day:");
                d = Convert.ToInt32(Console.ReadLine());
                Console.Write($"Month:");
                m = Convert.ToInt32(Console.ReadLine());
                Console.Write($"Year:");
                y = Convert.ToInt32(Console.ReadLine());

                HiringDate date = new HiringDate(d, m, y);

                employees[i].SetHiringDate(date);
            }

            Console.WriteLine($"\n\n Displaying Employees Data ....");

            foreach (var emp in employees)
            {
                Console.WriteLine(emp.ToString());
            }

            Console.ReadLine();
        }
    }
}
