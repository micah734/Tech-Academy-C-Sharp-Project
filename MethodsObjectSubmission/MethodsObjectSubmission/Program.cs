using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsObjectSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(); //instantiating the class employee
            employee.FirstName = "Sample";
            employee.LastName = "Student";

            employee.SayName(); //calling and setting the name
            Console.ReadLine();
        }
    }
}
