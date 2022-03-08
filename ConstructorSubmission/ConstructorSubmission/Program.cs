using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSubmission
{
    public class constructor
    {
        public constructor()
        {
            Console.WriteLine("This Constructor has no parameters");

        }
        public constructor(int x) : this()
        {
            Console.WriteLine("Constructor 2, value: {0}", x);
        }
        public constructor(int x, int y) : this(x)
        {
            Console.WriteLine("Constructor 3, value1: {0} & value2:{1}", x, y);
        }
    }

    public class Program
    {

        static void Main(string[] args)


        {
        constructor constructor = new constructor(9, 43);
         
        const string Name = "Micah Gooden";//assigning a constant of Micah Gooden for the Name variable

        var cost = 123.0m; //using var to create a variable that is not strongly typed and figured out by the program

            Console.WriteLine(Name);
            Console.WriteLine(cost);
            Console.Read();


        }
    }
}
