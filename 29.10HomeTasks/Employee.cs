using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29._10HomeTasks
{
    class Employee
    {
        public string name;
        public string surname;
        public string position;
        public int dailySalary;

         public static int salary(int dailySalary)
        {

            int monthSalary = dailySalary * 30;
            Console.WriteLine($"My month Salary = {monthSalary}");
            return monthSalary;
        }

    }
}
