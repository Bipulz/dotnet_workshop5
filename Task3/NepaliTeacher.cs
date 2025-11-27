using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class NepaliTeacher : Teacher
    {
        // Overrides the base Teaching() method for Nepali teaching style
        public override void Teaching()
        {
            Console.WriteLine("This teacher conducts classes in the Nepali language!");
        }
    }
}
