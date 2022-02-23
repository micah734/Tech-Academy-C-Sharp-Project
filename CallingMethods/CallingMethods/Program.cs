using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            Console.WriteLine("Please enter a number to do some math!");
            int userInput=Convert.ToInt32(Console.ReadLine());
            
            
           int addition=math.Add(userInput, 2);
           int subtraction=math.Subtract(userInput, 2);
           int multiplication=math.Multiply(userInput, 3);

            Console.WriteLine(addition);
            Console.WriteLine(subtraction);
            Console.WriteLine(multiplication);



            Console.ReadLine();

        }
    }
}
