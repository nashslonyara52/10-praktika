using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_2
{
    internal class Employee

    {
        private string name;
        private decimal salary;

        public string Name
        {
            get { return name; }
            set { name = value ?? "неизвестный"; }

        }

        public decimal Salary
        {
            get { return salary; }
            set
            {
                if (value < 0 || value > 1000000)
                {
                    Console.WriteLine("Зарплата не может быть отрицательной или больше 1000000!");
                    return;
                }

                salary = value;
            }
        }
        public Employee(string name, decimal salary)
        {
            Name = name;
            Salary = salary;
        }

        public Employee(string name) : this(name, 50_000m)
        {
        }

        public void Work()
        {
            Console.WriteLine($"{Name} работает, зарплата: {Salary}.");
        }


        static void Main(string[] args)
        {

            Employee employee1 = new Employee("Фекла", 200000);
            employee1.Work();

            Employee employee2 = new Employee("Иосиф");
            employee2.Work();

            employee2.Salary = -1000;


        }
    }
}
    
 


