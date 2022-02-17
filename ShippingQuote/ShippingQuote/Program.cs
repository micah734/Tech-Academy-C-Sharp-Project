using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");//Introduction to the app
            Console.WriteLine("Please input the weight of the package."); //Input the weight of package
            int weight = Convert.ToInt32(Console.ReadLine()); //Convert input to a int

            if (weight >50) //if weight is over 50 write this;
            {
                Console.WriteLine("Package is too heavy to be shipped via Package Express. Have a good day.");
                Console.Read();
            }
            if (weight <50) //if weight is less than 50, continue on
            {
                Console.WriteLine("Please input the width of the package."); //package width
                int width = Convert.ToInt32(Console.ReadLine());    //package width converted to int.
                Console.WriteLine("Please input the height of the package."); //package height
                int height = Convert.ToInt32(Console.ReadLine());   //package height converted to int.
                Console.WriteLine("Please input the length of the package."); //package length
                int length = Convert.ToInt32(Console.ReadLine());   //package length converted to int.

                if (width+height+length>50)  //adding up the dimensions if more than 50 following message displayed
                {
                    Console.WriteLine("Package is too big to be shipped via Package Express");
                    Console.Read();
                }

                else if (width+height+length<50) //if dimensions are less than 50 continue on.
                {
                    decimal dimensions = ((width * height * length) * weight) / 100; //converted to a decimal number since we are turning it into money.
                    Console.WriteLine("Your estimated total for shipping this package is:" + "$" + dimensions); //message displaying the cost for the item to ship 
                    Console.WriteLine("Thank You!"); //closing thanks.
                    Console.Read();

                }
            }
        }
    }
}
