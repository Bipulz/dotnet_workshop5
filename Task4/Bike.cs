using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Bike : Vehicle
    {
        // Starts the engine specific to a bike
        public override void StartEngine()
        {
            Console.WriteLine("Bike engine has been started.");
        }

        // Stops the bike engine
        public override void StopEngine()
        {
            Console.WriteLine("Bike engine has been stopped.");
        }
    }
}
