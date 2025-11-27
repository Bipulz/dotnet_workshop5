using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Teacher
    {
        public string Name { get; set; }

        // Default teaching method (English)
        public virtual void Teaching()
        {
            Console.WriteLine("This teacher teaches in English by default.");
        }

        // Sample salary information
        public void SalaryInfo()
        {
            Console.WriteLine("Teacher's monthly salary: Rs. Sarai_Thorai (demo value).");
        }
    }
}
