using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal class Smartphone : ElectronicDevice
    {
        public Smartphone(string brand, double price) : base(brand, price)
        {
        }

        // Smartphone-specific behavior
        public void EnableCamera()
        {
            Console.WriteLine("Smartphone camera has been enabled.");
        }

        // Display smartphone details
        public override void ShowInfo()
        {
            Console.WriteLine($"Smartphone - Brand: {Brand} | Price: Rs.{Price}");
        }
    }
}
