using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal abstract class Vehicle
    {
        // Abstract engine methods that must be implemented by derived classes
        public abstract void StartEngine();
        public abstract void StopEngine();

        // Displays basic vehicle info
        public void Display()
        {
            Console.WriteLine("This is a type of vehicle.");
        }
    }
}
