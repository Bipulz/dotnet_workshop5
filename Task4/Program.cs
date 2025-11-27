using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Task 4: Vehicle Engine Demonstration ===\n");

            // Car demonstration
            Car car = new Car();
            Console.WriteLine("---- Car Operations ----");
            car.StartEngine();
            car.Display();
            car.StopEngine();

            Console.WriteLine();

            // Bike demonstration
            Bike bike = new Bike();
            Console.WriteLine("---- Bike Operations ----");
            bike.StartEngine();
            bike.Display();
            bike.StopEngine();
        }
    }
}
