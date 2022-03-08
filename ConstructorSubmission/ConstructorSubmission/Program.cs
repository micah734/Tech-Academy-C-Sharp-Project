using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSubmission
{
    class Program
    {
        public string userName { get; set; }
        public int idNumber {get; set;}
        public Program(string userName, int idNumber)
        {
            this.userName = userName; //stringing constructors together.
            this.idNumber = idNumber;
        }
        static void Main(string[] args)

           
        {
            
        const string Name = "Micah Gooden";//assigning a constant of Micah Gooden for the Name variable

        var cost = 123.0m; //using var to create a variable that is not strongly typed and figured out by the program

            Console.WriteLine(Name);
            Console.WriteLine(cost);
            Console.Read();


        }
    }
}
