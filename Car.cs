using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lecture
{
    class Car
    {
        // 'Стан1 об'єкта Car.
        public string petName;
        public int currSpeed;
        // Функціональність Car.
        public void PrintState()
        {
            Console.WriteLine("{0} is going {1} MPH.", petName, currSpeed);
        }
        public void SpeedUp(int delta)
        {
            currSpeed += delta;
        }
        
        private static int CountOfCars = 0;
        private string manufacturer;
        private string model;
        // properties	

        public Car(string manufacturer, string model)
        {
            this.manufacturer = manufacturer;
            this.model = model;
            CountOfCars++;
        }
        public static int GetCountOfCars() => CountOfCars;
        // other class members 	
    }

}

