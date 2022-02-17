using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsurance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insurance Approval Questionaire"); //Questions asked
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int ages = Convert.ToInt32(age);            //answer converted to integer
            Console.WriteLine("Have you ever had a DUI? Please answer true or false.");
            string duianswer = Console.ReadLine();
            bool dui = Convert.ToBoolean(duianswer);    //answer converted to boolean
            Console.WriteLine("How many speeding tickets do you have?");
            string ticketanswer = Console.ReadLine();
            int tickets = Convert.ToInt32(ticketanswer); //answer converted to integer

            Console.WriteLine("Qualified for insurance?");
            Console.WriteLine(ages >= 15 && dui == false && tickets <= 3); //taking the information and seeing if they are qualified using boolean logic

            Console.Read();


        }
    }
}
