using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal class ElectronicStore
    {
        private List<ElectronicDevice> devices = new List<ElectronicDevice>();

        // Add new electronic device to store
        public void AddDevice(ElectronicDevice device)
        {
            devices.Add(device);
            Console.WriteLine($"{device.Brand} has been added to the store.");
        }

        // Remove existing device from store
        public void RemoveDevice(ElectronicDevice device)
        {
            devices.Remove(device);
            Console.WriteLine($"{device.Brand} has been removed from the store.");
        }

        // Display info of all devices and trigger specific actions
        public void ShowAllDeviceDetails()
        {
            Console.WriteLine("=== Store Device Details ===\n");

            foreach (var device in devices)
            {
                device.ShowInfo();   // Show device-specific info

                // Extra actions depending on device type
                if (device is Laptop laptop)
                {
                    laptop.TurnOnBattery();
                }
                else if (device is Smartphone smartphone)
                {
                    smartphone.EnableCamera();
                }
            }
        }
    }
}
