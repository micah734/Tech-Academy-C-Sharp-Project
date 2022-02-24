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
            Integers integers = new Integers();

            integers.sum(5, 12);

            integers.sum(a: 13, b: 11);

            Console.ReadLine();

        }
    }
}
