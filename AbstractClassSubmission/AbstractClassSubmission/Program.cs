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
            employee.Id = 1234;

            employee.SayName(); //calling the abstract method.


            Employee employee1 = new Employee();
            employee1.firstName = "Steve";
            employee1.lastName = "Jobs";
            employee1.Id = 5678;

            quittable.Quit();

            Console.WriteLine("Is employee equal to employee 1:" + (employee == employee1));
            
            
            

            Console.ReadLine();
        }
    }
}
