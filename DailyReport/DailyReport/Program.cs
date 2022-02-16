using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy\nStudent Daily Report"); //Name introduction
            Console.WriteLine("What is your name?"); //Getting Name
            string yourName = Console.ReadLine();   //Saving name
            Console.WriteLine("What course are you on?"); //Asking course name
            string courseName = Console.ReadLine(); //Saving Course name
            Console.WriteLine("What page number?"); //getting page number
            string pageNumber = Console.ReadLine(); //saving the string to a variable
            int page = Convert.ToInt32(pageNumber); //converting the variable to an integer
            Console.WriteLine("Do you need help with Anything? Please answer \"true\" or \"false\"");
            string needHelp = Console.ReadLine(); //Saving True or False as string
            bool help = Convert.ToBoolean(needHelp); //Converting String to a boolean
            Console.WriteLine("Where there any positive experiences you\'d like to share? Please be specific");
            string experience = Console.ReadLine(); //saving experience
            Console.WriteLine("How many hours did you study today?"); //asking question how much you studied
            string hoursStudied = Console.ReadLine(); //saved the string to a variable
            int hours = Convert.ToInt32(hoursStudied); //converted the variable to an integer
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!"); //Finished out with a confirmation
            Console.Read(); //Used to keep the window opened.

        }
    }
}
