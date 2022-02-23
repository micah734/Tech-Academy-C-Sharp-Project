using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringIntegersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<int> listNumbers = new List<int> { 8, 12, 24, 34 };//my list of integers
            
            try //start of try loop
            {
                Console.WriteLine("Please pick a number to divide with:"); //asking the user to pick a number
                int userInput = Convert.ToInt32(Console.ReadLine()); //converting the input into an integer
                for (int i = 0; i < listNumbers.Count; i++) //for loop to go through each number dividing by the user input
                {
                    Console.WriteLine(listNumbers[i] / userInput);//showing the output of the division on the screen
                }
                Console.ReadLine();
            }

            catch(FormatException ex) //format exception will display if person using a string for the input
            {
                Console.WriteLine("Please type a integer Ex. 4");
                return;
            }
            catch(DivideByZeroException ex) //if user puts a 0, this error will show asking them not to divide by 0
            {
                Console.WriteLine("Please do not divide by 0");
            }
            catch(Exception ex) //put just in case the user tries to use other characters so the program doesn't crash.Might not be needed.
            {
                Console.WriteLine(ex.Message);
            }
            finally //This will run no matter what happens in the try/catch loop.
            {
                Console.WriteLine("You have exited the try and catch loop. Thank You have a good day.");
                Console.ReadLine();
            }
            
        }
    }
}
