using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(); //instatiation of class employee
            IQuittable quittable = new Employee();

            employee.firstName = "Sample"; //giving name 
            employee.lastName = "Student";

            employee.SayName(); //calling the abstract method.


           
            quittable.Quit();
            

            
            

            Console.ReadLine();
        }
    }
}
