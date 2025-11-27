using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Welcome to Task 3 Demonstration ===\n");

            // Printer examples
            Printer printer = new Printer();
            printer.Print("Hello, World!");
            printer.Print(36);
            printer.Print("Hello k chha hau", 36);

            Console.WriteLine("\n-----------------------------------------\n");

            // Nepali Teacher
            NepaliTeacher nepaliTeacher = new NepaliTeacher();
            nepaliTeacher.Teaching();
            nepaliTeacher.Name = "Ram Bahadur";
            Console.WriteLine("Teacher's Name: " + nepaliTeacher.Name);
            nepaliTeacher.SalaryInfo();

            Console.WriteLine("\n-----------------------------------------\n");

            // English Teacher
            EnglishTeacher englishTeacher = new EnglishTeacher();
            englishTeacher.Teaching();
            englishTeacher.Name = "Shyam Bahadur";
            Console.WriteLine("Teacher's Name: " + englishTeacher.Name);
            englishTeacher.SalaryInfo();
        }
    }
}
