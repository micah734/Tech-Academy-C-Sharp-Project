using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the current day of the week");
            try
            {
               string userInput = Console.ReadLine();
               DaysOfTheWeek.Parse(typeof(DaysOfTheWeek),userInput);
               DaysOfTheWeek dayoftheweek = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), userInput);
               Console.WriteLine(dayoftheweek);

            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the Week");
                Console.WriteLine("Hello");
            }

            Console.ReadLine();
        }

        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
