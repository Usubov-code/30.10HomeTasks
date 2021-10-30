using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29._10HomeTasks
{
    class Person
    {
        public byte age;
        public static void Greet()
        {
            Console.WriteLine("Hi how old are you?");

        }
        
        public static void SetAge(int age)
        {

            Console.WriteLine($"I am {age}");
        }
    }
}
