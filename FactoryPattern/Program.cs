using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int wheelCount;
            bool input = false;

            do
            {
                Console.WriteLine("Enter the amount of tires your new vehicle has:");
                input = int.TryParse(Console.ReadLine(), out wheelCount);
            }
            while (input ==  false);

            var vehicle = VehicleFactory.GetVehicle(wheelCount);
            vehicle.Drive();

        }
    }
}

