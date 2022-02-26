using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmission
{
    public abstract class Person //defining the abstract class
    {
        public string firstName { get; set; }
        public string lastName { get; set; }


        public abstract void SayName(); //setting that this method must be included
        
        
    }
}
