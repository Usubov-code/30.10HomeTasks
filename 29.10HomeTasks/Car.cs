using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29._10HomeTasks
{
    class Car : Vehicle
    {
        
        public string color;
        public int fuelCapacity;
        public byte doorCount;
        public int consumption;

       

        public static void ways(int fuelCapacity ,int consumption)
        {

            int way = 0;
            way = fuelCapacity/consumption;
            Console.WriteLine($"the way to go with full depo {way}");

        }



    }
}
