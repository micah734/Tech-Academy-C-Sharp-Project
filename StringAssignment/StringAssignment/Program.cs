using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string part1 = "My name is:"; //concatenating 3 strings together to make one
            string part2 = " Micah.";
            string part3 = " What is your name?";
            Console.WriteLine(part1 + part2 + part3);

            string part4 = "my name is yelling!";
            Console.WriteLine(part4.ToUpper()); //converts the string to all uppercase.

            StringBuilder sb = new StringBuilder(); //Uses StringBuilder to keep adding on to the story.
            sb.Append("\tOnce upon a time,");
            sb.Append("there was a little boy.");
            sb.Append(" His name was Frankie.");
            sb.Append(" He was a Giant killer.");
            sb.Append(" He killed every Giant he could see.\n");
            sb.Append("THE END. (That was a great story,wasn't it?)");
            Console.WriteLine(sb);

            Console.Read();
        }
    }
}
