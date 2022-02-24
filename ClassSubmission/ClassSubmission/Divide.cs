using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission
{
    public class Divide
    {
        public void divideBy(int a, int b=2)
        {
            int byTwo = a / b;
            Console.WriteLine(byTwo);

        }

        public void divideBy(decimal a, decimal b = 3.66m)
        {
            decimal byThree = a / b;
            Console.WriteLine(byThree);
        }

        public void calculate(int length, int width, out int area)
        {
            area = length * width;
        }


    }
}
