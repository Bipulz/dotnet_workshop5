using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Task 5 - Electronic Store System\n");

            ElectronicStore store = new ElectronicStore();

            Laptop laptop = new Laptop("MacBook Pro", 150000);
            Smartphone smartphone = new Smartphone("Redmi Note 12", 22000);

            store.AddDevice(laptop);
            store.AddDevice(smartphone);

            store.ShowAllDeviceDetails();
        }
    }
}
