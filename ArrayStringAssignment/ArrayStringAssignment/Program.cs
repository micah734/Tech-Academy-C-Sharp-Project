using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayStringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Fred", "Wilma", "Johnny", "Frank", "Willamina", "Joe" };

            Console.WriteLine("Please type a adjective to describe a person, place or thing.");
            string userInput = Console.ReadLine();


            foreach (string s in names)
            {
                string b = s + " "+ userInput;
                Console.WriteLine(b);
            }

            //fixed infinite loop
            for(int i=0; i<12; i++ )
            {
                Console.WriteLine("This is a loop");
            }


            for(int i=0; i<5; i++)
            {
                Console.WriteLine("This is another terminating loop");
            }


            Console.WriteLine("Pick a number"); //Comparison Loop
            int j=Convert.ToInt32(Console.ReadLine());

            if (j <= 12)
            {
                Console.WriteLine("This is less than 12");
            }
            else
            {
                Console.WriteLine("This is more than 12");
            }


            List<string> girlsNames= new List<string> { "Wilma", "Freda", "Holly", "Lilly", "Megan", "Liz" }; //List of names
            Console.WriteLine("Search the list of girls names");
            string search=Console.ReadLine();

            foreach(string name in girlsNames)
            {
                int index = girlsNames.FindIndex(a => a.Contains(search)); //getting the search term index
                if (index >= 0)  //if included in the index, this will run
                {

                    Console.WriteLine("Item is found at index: " + index);
                        break;
                }

                else //if null comes up, then this is the response.
                {
                    Console.WriteLine("There is not a name in this list matching the search terms.");
                    break;

                }
            }


            List<string> boysNames = new List<string> { "Maverick", "Mason", "Tom", "Jacob", "Micah", "Harry", "Micah"};
            Console.WriteLine("Search the list of boys names");
            string boysearch = Console.ReadLine();
            int boyIndex = boysNames.FindIndex(a => a.Contains(boysearch));

            for (int i=0; i<boysNames.Count(); i++)
            {
                if (boyIndex > -1)
                {
                    Console.WriteLine("The index for the name is: " + boyIndex);
                    break;
                }

                else
                {
                    Console.WriteLine("There is not a name in this list that matches.");
                    break;
                }
            }

            Console.ReadLine();




        }
    }
}
