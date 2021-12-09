using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonParking
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>()
            {
                new Car(){name ="Ford",Number = "A001AA01"},
                new Car(){name ="Lada",Number = "B727ET77"}
            };

            var parking = new Parking();

            foreach (var car in cars)
            {
                parking.Add(car);
            }
        }
    }
}
