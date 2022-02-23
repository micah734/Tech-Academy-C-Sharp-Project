using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            integer integer = new integer();

            int division = integer.Divide(32, 4); //dividing by the two numbers
            Console.WriteLine(division);

           
            decimal multiply = integer.Divide(33.12m,31.20m); //times by the numbers
            Console.WriteLine(multiply);


            int addition = integer.Divide("8", "12"); //converted to an integer, then added together
            Console.WriteLine(addition);

            Console.ReadLine();
        }
    }
}
