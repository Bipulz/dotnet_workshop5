using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Car : Vehicle
    {
        // Starts the engine specific to a car
        public override void StartEngine()
        {
            Console.WriteLine("Car engine has been started.");
        }

        // Stops the car engine
        public override void StopEngine()
        {
            Console.WriteLine("Car engine has been stopped.");
        }
    }
}
