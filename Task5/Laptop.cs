using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal class Laptop : ElectronicDevice
    {
        public Laptop(string brand, double price) : base(brand, price)
        {
        }

        // Laptop-specific behavior
        public void TurnOnBattery()
        {
            Console.WriteLine("Laptop battery has been turned ON.");
        }

        // Display laptop details
        public override void ShowInfo()
        {
            Console.WriteLine($"Laptop - Brand: {Brand} | Price: Rs.{Price}");
        }
    }
}
