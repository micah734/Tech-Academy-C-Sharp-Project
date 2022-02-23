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
            Console.WriteLine(names.Length);

            Console.WriteLine("Please type a adjective to describe a person, place or thing.");
            string userInput = Console.ReadLine();

            for(int i=0;i<=5; i++) //If I tried to put i<=names.Length I got an error, so this is the only way it would run.
            {
               names[i]+=userInput;
            }
            for(int i=0;i<=5; i++)
            {
                Console.WriteLine(names[i]);
            }
          
            //foreach (string s in userInput)
            //{
         
            //    Console.WriteLine(s);
            //}

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

            for(int i=0; i<=j;i++)
            {
                Console.WriteLine("Another loop");
            }

            //if (j <= 12)
            //{
            //    Console.WriteLine("This is less than 12");
            //}
            //else
            //{
            //    Console.WriteLine("This is more than 12");
            //}


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
            

            for (int i=0; i<boysNames.Count(); i++)
            {
                if (!boysNames.Contains(boysearch))
                {
                    Console.WriteLine("Not Included");
                    break;

                }
                else if (boysearch==boysNames[i])
                {
                    Console.WriteLine("The index for the name is: " + i);

                                                                         
                }

                
                             
            }

            List<string> guests = new List<string> { "Fred", "Fred", "Margo", "George", "Micah","Micah" };
            List<string> compare = new List<string>();
            Console.WriteLine("This is the duplicates on the list");

            foreach(string guest in guests)
            {
              


                if (compare.Contains(guest))
                {
                    Console.WriteLine("This has already appeared on the list." + guest);

                }

                compare.Add(guest);
            }

                


            Console.ReadLine();




        }
    }
}
