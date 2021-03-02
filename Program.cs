using System;

namespace Lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            Baggage baggageOne = new Baggage(10, 10, 10, 10);
            Baggage baggageTwo = new Baggage(20, 20, 20, 15);
            Console.WriteLine($"baggageOne volume:{baggageOne.GetVolume()}");
            Console.WriteLine($"baggageTwo volume:{baggageTwo.GetVolume()}");
            Console.ReadKey();


            PassengerCar car1 = new PassengerCar();
            car1.SpeedUp();
            PassengerCar car2 = new PassengerCar();
            car2.SpeedUp();
            PassengerCar.MaxSpeedUp();
            Console.WriteLine($"car speed is {car1.CurrentSpeed}");
            Console.WriteLine($"cars max speed is {PassengerCar.MaxSpeed}");
            Console.ReadKey();

            Baggage baggage = new Baggage(10, 10, 10, 10);
            Baggage otherBaggage = new Baggage(20, 20, 20, 20);
            Console.ReadKey();



        }

    }
}
