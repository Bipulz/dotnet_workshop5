using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Printer
    {
        // Prints a text message
        public void Print(string message)
        {
            Console.WriteLine($"[Text]: {message}");
        }

        // Prints a number
        public void Print(int number)
        {
            Console.WriteLine($"[Number]: {number}");
        }

        // Prints both a message and number
        public void Print(string message, int number)
        {
            Console.WriteLine($"[Combined] Message: \"{message}\" | Number: {number}");
        }
    }
}
