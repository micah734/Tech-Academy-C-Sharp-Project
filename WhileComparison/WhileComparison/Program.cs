using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Put in your favorite number."); //asked for fav number
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 7; //correct answer is 7

            do  //start of do loop, as we want this to be done at least once.
            {
                switch(number) //a set of possible answers and the reaction of the program
                {
                    case 1:
                        Console.WriteLine("Thats a good number but not the right one");
                        Console.WriteLine("Try another number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 3:
                        Console.WriteLine("Thats a good number, but not the right one");
                        Console.WriteLine("Try another number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 5:
                        Console.WriteLine("Thats a good number but not the right one");
                        Console.WriteLine("Try another number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 7: //the correct answer ends the loop and goes on to the next one
                        Console.WriteLine("That is a fantastic number, now give me another number");
                        isGuessed = true;           
                        break;

                    default: //the default response if not one of the above.
                        Console.WriteLine("That is incorrect");
                        Console.WriteLine("Try another number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }
            while (!isGuessed) ; //used to keep in the loop

            int number2 = Convert.ToInt32(Console.ReadLine());
            bool isGuessed2 = number == 12; //a boolean for a second number
            while (!isGuessed2) //while loop started

                switch (number2)
                {
                    case 11:
                        Console.WriteLine("That is a good second number, try adding one.");
                        Console.WriteLine("Try again");
                        number2 = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 12:
                        Console.WriteLine("That is the correct number! Congrats!");
                        isGuessed2 = true;
                        break;

                    default:
                        Console.WriteLine("That is incorrect, try again");
                        number2 = Convert.ToInt32(Console.ReadLine());
                        break;

                }

            Console.Read();
                
            
        }
    }
}
