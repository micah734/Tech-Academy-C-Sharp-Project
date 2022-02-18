using System;
using System.Collections.Generic;


namespace ArrayApp
{
    class Program
    {
        static void Main()
        {
            string[] stringArray = { "Hello", "Welcome", "Enter", "Project" }; //sets the string array
            Console.WriteLine("Pick a number to get the message to display using 0-3"); //ask for users input
                   
            int number = Convert.ToInt32(Console.ReadLine()); //takes user input and converts to number

            if(number<=3)  //if the number is between 0-3 it will write the number to the screen
            {
                Console.WriteLine(stringArray[number]);
                
            }
            else  //if number is outside 0-3 this will run saying that it does not exist.
            {
                Console.WriteLine("This index does not exist.");
                
            }


            int[] intArray = { 4, 42, 945, 47, 15 }; //initializing the integer array
            Console.WriteLine("Please pick another number between 0-4"); //asking the user to pick a number

            int number2= Convert.ToInt32(Console.ReadLine()); //converts input into a integer

            if (number2<= 4)  //if 0-4 is picked this will run
            {
                Console.WriteLine(intArray[number2]);
            }
            else  //anything outside of 0-4 this will run
            {
                Console.WriteLine("This index does not exist.");
            }

            List<string> stringList = new List<string>(); //making a string list
            stringList.Add("This");
            stringList.Add("Does");
            stringList.Add("Hopefully");
            stringList.Add("Work");

            Console.WriteLine("Please pick a number between 0 & 3 to display the word."); //asking for user input
            int number3 = Convert.ToInt32(Console.ReadLine());  //taking user input and converting to an integer

            if (number3 <= 3) //if number is 0-3 this will run
            {
                Console.WriteLine(stringList[number3]);
            }
            else  //if anything above 3, this will run
            {
                Console.WriteLine("This index does not exist.");
            }

            Console.Read(); //allows the window to stay open.
        }
    }
}
