using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Methods methods = new Methods();

            try
            {
                Console.WriteLine("Please give an integer");
                int userInput = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please give a second integer, this is optional, if you do not want to give a second one, hit enter");
                int input;
                bool inputResult = Int32.TryParse(Console.ReadLine(), out input);

                int result = methods.Integer(userInput, input);

                Console.WriteLine(result);
                Console.ReadLine();
            }
            catch
            {
                int data;
                bool dataResult = Int32.TryParse(Console.ReadLine(), out data);
                int result = methods.Integer(data);
                Console.WriteLine(result);

                Console.ReadLine();
            }




            //if (userInput )
            //{
            //    int b = Convert.ToInt32(Console.ReadLine());
            //    int answer = methods.Integer(userInput, b);
            //    Console.WriteLine(answer);
            //}
            //else
            //{
            //    int answer = methods.Integer(userInput);
            //    Console.WriteLine(answer);
            //}

            

            

            Console.Read();

        }
    }
}
