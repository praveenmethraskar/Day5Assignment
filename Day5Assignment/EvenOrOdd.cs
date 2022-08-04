using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignment
{
    public class EvenOrOdd
    {
        public void Even_Or_Odd()
        {
            Console.WriteLine("Enter a Number to find it is Even or Odd");

            int num = Int32.Parse(Console.ReadLine());
            int rem;

            rem = num % 2;

            if(rem == 0)
            {
                Console.WriteLine("{0} Entered Number is Even",num);
            }
            else
            {
                Console.WriteLine("{0} Entered Number is odd", num);
            }

        }
    }
}
