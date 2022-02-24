using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Integers integers = new Integers(); //instantiated the method

            integers.sum(5, 12); //passed the parameters

            integers.sum(a: 13, b: 11); //showing the names of the parameters and passing in a number

            Console.ReadLine();

        }
    }
}
