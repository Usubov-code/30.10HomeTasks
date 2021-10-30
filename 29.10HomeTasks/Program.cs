using System;

namespace _29._10HomeTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            #region task1 task 2
            //Console.WriteLine("Please enter the Car Brand name");
            //string brand = Console.ReadLine();
            //Console.WriteLine("Enther the Car Model");
            //string model = Console.ReadLine();
            //Car.arg(model, brand);

            #endregion
            #region task 3
            //Console.WriteLine("enter the fuel capacity ");
            //int fuelCapacity = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter consumption car");
            //int consumption = Convert.ToInt32(Console.ReadLine());


            //Car.ways(fuelCapacity,consumption);
            #endregion

            #region task  4,5
            //Bicyrcle bic1 = new Bicyrcle();
            //Console.WriteLine("Please enter the Bicyrcle brand");
            //string brand =Console.ReadLine();
            //Console.WriteLine("Please enter the Bicyrcle model");
            //string model = Console.ReadLine();

            //Bicyrcle.arg(brand, model);
            #endregion

            #region task 6;
            //Employee emp1 = new Employee();

            //Console.WriteLine("pls enter the daily salary");
            // int dailySalary = Convert.ToInt32(Console.ReadLine());

            //Employee.salary(dailySalary);
            #endregion

            #region Task Volumeof box
            //Volume vol1 = new Volume();

            //Console.WriteLine("please enter the width");
            //int width = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("please enter the length");
            //int length = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("please enther the height");
            //int height = Convert.ToInt32(Console.ReadLine());


            //Volume.volumeOfbox(width, length, height);

            #endregion

            #region Task Teacher ,student,people

            //Student stu1 = new Student();
            //Console.WriteLine("You are student? ");
            //string study = Console.ReadLine();
            //Student.Study(study);

            // Person per1 = new Person();
            // Person.Greet();
            //int age=Convert.ToInt32( Console.ReadLine());
            // Person.SetAge(age);


            // Teacher.Explain();



            // Student.ShowAge(age);
            #endregion
            #region Student Class task

            Student stu2 = new Student();
            Console.WriteLine("Enter your  Full name ,course, subject ,university, email and phone number");
          stu2.fullName= Console.ReadLine();
            stu2.course = Convert.ToByte(Console.ReadLine());
            stu2.subject =Console.ReadLine();
            stu2.university = Console.ReadLine();
            stu2.email = Console.ReadLine();
            stu2.phoneNumber = Console.ReadLine();

            stu2.fullInfo(stu2);

            #endregion

        }
    }
}
