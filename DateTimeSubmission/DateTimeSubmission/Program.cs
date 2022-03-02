using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1=DateTime.Now;//getting the current time and date
            Console.WriteLine(d1); //writing the time to the console.
            Console.WriteLine("Give me a number"); //asking for a number from the user
            int userInput = Convert.ToInt32(Console.ReadLine()); //converting to an interval
            DateTime d2 = d1.AddHours(userInput); //taking the current time and adding the number the user gave to get the new time
            Console.WriteLine("It will be {0} in {1} hours",d2,userInput); //writing line to the console.
            Console.ReadLine();
        }
    }
}
