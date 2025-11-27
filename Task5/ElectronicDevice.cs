using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal abstract class ElectronicDevice
    {
        private string brand;
        private double price;

        // Device brand property
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        // Device price property with validation
        public double Price
        {
            get { return price; }
            set
            {
                if (value > 0)
                    price = value;
                else
                    Console.WriteLine("Price cannot be negative. Please enter a valid amount.");
            }
        }

        // Constructor to initialize brand and price
        public ElectronicDevice(string brand, double price)
        {
            Brand = brand;
            Price = price;
        }

        // Abstract method for displaying device information
        public abstract void ShowInfo();
    }
}
