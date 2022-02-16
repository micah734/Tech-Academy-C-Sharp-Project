using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousIncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program"); //heading

            //Info from person 1
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate:"); //hourly rate inputed
            string hourlyRate= Console.ReadLine(); //hourlyrate read 
            decimal rate = Convert.ToDecimal(hourlyRate); //converted to an integer
            Console.WriteLine("Hours worked per week:"); //Number of hours worked weekly inputed
            string hoursPerWeek = Console.ReadLine(); //read and stored
            decimal perWeek = Convert.ToDecimal(hoursPerWeek); //converted to an integer

            //Info from person 2
            Console.WriteLine("Person 2"); //person 2 info inputed
            Console.WriteLine("Hourly Rate:"); 
            string hourlyRate2 = Console.ReadLine(); //hourlyrate read and saved 
            decimal rate2 = Convert.ToDecimal(hourlyRate2); //hourly rate converted to int
            Console.WriteLine("Hours worked per week:"); //hours per week inputed
            string hoursPerWeek2 = Console.ReadLine(); //hours per week saved
            decimal perWeek2 = Convert.ToDecimal(hoursPerWeek2); //hours per week converted

            //Calculating annual salary of person 1
            Console.WriteLine("Annual salary of Person 1:");
            decimal annualSalary = (rate * perWeek) * 52; //taking the rate * hours worked weekly then times the number of weeks in a year.
            Console.WriteLine(annualSalary);

            //Calculating annual salary of person 2
            Console.WriteLine("Annual salary of Person 2:");
            decimal annualSalary2 = (rate2 * perWeek2) * 52; //taking the rate * hours worked weekly then times the number of weeks in a year.
            Console.WriteLine(annualSalary2);

            Console.WriteLine("Does Person 1 make more money than Person 2?"); //comparison of the two peoples annual salary
            bool comparison=annualSalary > annualSalary2;
            Console.WriteLine(comparison);
            Console.Read();
        }
        
    }
}
