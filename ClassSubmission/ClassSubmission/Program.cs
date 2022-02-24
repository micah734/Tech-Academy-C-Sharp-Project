using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Divide divide = new Divide();

            Console.WriteLine("Please enter a number to divide by");//Asking for a number
            int userInput = Convert.ToInt32(Console.ReadLine()); //converting the number
           
            divide.divideBy(userInput); //calling the method and dividing by two

            Console.WriteLine("Please enter another number"); //asking for another number
            decimal userInput2 = Convert.ToDecimal(Console.ReadLine()); //converting the number to a decimal

            divide.divideBy(userInput2); //using overloading taking the userInput2 and dividing by 3.66m
            

            int area; //declaring an empty interval
            divide.calculate(length: 5, width:10, out area); //using the method and bring out the area
            Console.WriteLine("The area of a rectangle is: {0}", area);//taking the area and putting it in a writeline.


            var subject = Methods.type;  //using static class 
            Console.WriteLine(subject); //displaying the info in static class

            Console.ReadLine();
        }
        
    }
}
