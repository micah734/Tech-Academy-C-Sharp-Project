using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmission
{
    public class Employee:Person,IQuittable //inheriting from Person class
    {
        public override void SayName() //defining and setting up the abstract method
        {
            Console.WriteLine(firstName + " " + lastName);

           
            
        }

        public void Quit()
        {
            Console.WriteLine(firstName + " " + lastName + " has decided to quit");
        }

        
    }
}
