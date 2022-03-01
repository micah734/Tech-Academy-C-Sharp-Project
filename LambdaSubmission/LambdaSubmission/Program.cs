using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Employees> employees = new List<Employees>();
            employees.AddRange(new List<Employees>
            {

                new Employees { Id = 112, firstName = "Bob", lastName = "Jones" },
                new Employees { Id = 113, firstName = "Joe", lastName = "Jones" },
                new Employees { Id = 119, firstName = "Joe", lastName = "Smith" },
                new Employees { Id = 339, firstName = "Micah", lastName = "Gooden" },
                new Employees { Id = 987, firstName = "Megan", lastName = "Francis" },
                new Employees { Id = 001, firstName = "Steve", lastName = "Jobs" },
                new Employees { Id = 999, firstName = "Bill", lastName = "Gates" },
                new Employees { Id = 114, firstName = "Liz", lastName = "Jones" },
                new Employees { Id = 100, firstName = "Frankie", lastName = "Valley" },
                new Employees { Id= 928, firstName="Lillian", lastName="George" },
            });

            
            List<Employees> search = new List<Employees>();
            foreach (Employees employee in employees)
            {
                if (employee.firstName=="Joe")
                {
                    
                    search.Add(employee);
                }
            }

            List<Employees> emp = employees.FindAll(e => (e.Id > 5));
            Console.WriteLine(emp);


            Console.WriteLine();
           Console.ReadLine();







        }
    }
}
public class Employees
{
    public int Id { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
}