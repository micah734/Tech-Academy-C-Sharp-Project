using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberInputs
{
    class Program
    {
        static void Main(string[] args)
        {   //Number 1
            Console.WriteLine("Please pick a number:"); //picks a number
            string num = Console.ReadLine();    //reads the line
            int number = Convert.ToInt32(num);  //converts to a int
            int multiply = number * 50;         //multiplies by 50
            Console.WriteLine(multiply);        //writes the number.

            //Number 2
            Console.WriteLine("Please pick another number:"); //picks a number
            string num2 = Console.ReadLine();    //reads the line
            int number2 = Convert.ToInt32(num2);  //converts to a int
            int adds = number +25;         //adds 25
            Console.WriteLine(adds);        //writes the number.

            //Number 3
            Console.WriteLine("Please pick another number:");
            string num3 = Console.ReadLine();
            float number3 = Convert.ToInt32(num3);      //Converts to float
            float divides = number3 / 12.5f;            //divides number
            Console.WriteLine(divides);                 //prints number

            //Number 4
            Console.WriteLine("Please pick another number:");
            string num4 = Console.ReadLine();
            int number4 = Convert.ToInt32(num4);        //converts to int
            bool isGreater = number4 > 50;              //checks condition
            Console.WriteLine(isGreater);               //writes True or False

            //Number 5
            Console.WriteLine("Please insert a number:");
            string num5 = Console.ReadLine();
            int number5 = Convert.ToInt32(num5);
            int modular = number5 % 7; //getting the remainder of the number divided by 7
            Console.WriteLine(modular);
            Console.ReadLine();

          

            //



        }
    }
}

