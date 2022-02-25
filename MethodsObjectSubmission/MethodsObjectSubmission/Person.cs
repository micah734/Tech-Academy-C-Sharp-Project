using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsObjectSubmission
{
    public class Person
    {
        public string FirstName { get; set; } //setting property FirstName
        public string LastName { get; set; } //setting property LastName


        public void SayName()
        {
            Console.WriteLine("Name: " +FirstName +" "+LastName);//Writes to the console
        }
    }
}
