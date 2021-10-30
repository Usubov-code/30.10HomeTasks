using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29._10HomeTasks
{
    class Student : Person
    {
        //public string study;

        //public static void Study(string study)
        //{

        //    Console.WriteLine("I am Studying");


        //}

        //public static void ShowAge(int age)
        //{

        //    Console.WriteLine($"My age is :{age} years old ");
        //    }

        public string fullName;
        public byte course;
        public string subject;
        public string university;
        public string email;
        public string phoneNumber;

        //public Student(string fullName, string university)
        //{
        //    this.fullName = fullName;
        //    this.university = university;

        //}

        public void fullInfo(Student stu2)
        {

            Console.WriteLine($" I am {stu2.fullName} ,study course {stu2.course} my faculty {stu2.subject} {stu2.university}. My e-mail {stu2.email}  and {stu2.phoneNumber}");
        }



    }
}
