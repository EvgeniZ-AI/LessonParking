using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonParking
{
    class Parking
    {
        private List<Car> _cars = new List<Car>();

        private const int MAX_CARS = 100;

        public int Count => _cars.Count;

        public string Name { get; set; }

        public int Add(Car car)
        {
            if (car == null)
            {
                throw new ArgumentNullException(nameof(car), "car is null");
            }

            if (_cars.Count < MAX_CARS)
            {
                _cars.Add(car);
                return _cars.Count - 1;
            }
            return -1;
        }
        public void GoAut(string number)
        {
            if (string.IsNullOrWhiteSpace(number))
            {
                throw new ArgumentNullException(nameof(number), "number i null or empety.");
            }

            var car = _cars.FirstOrDefault(c => c.name == number);
            if (car != null)
            {
                _cars.Remove(car);
            }
        }
    }
}
