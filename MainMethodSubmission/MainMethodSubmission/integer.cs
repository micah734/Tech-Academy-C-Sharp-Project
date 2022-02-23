using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodSubmission
{
    class integer
    {
        public int Divide(int a, int b)
        {
            return a/b; //returned to the main program
        }

        public int  Divide(decimal c, decimal d)//format is decimal
        {
            int x = Convert.ToInt32(c);
            int y = Convert.ToInt32(d);
            return x * y; //returned to the main program
        }

        public int Divide(string e, string f) //format is strings
        {
           int g=Convert.ToInt32(e); //converted to interval
           int h= Convert.ToInt32(f); //converted to interval
            return g + h;             //returned to the main program  

        }
    }
}
