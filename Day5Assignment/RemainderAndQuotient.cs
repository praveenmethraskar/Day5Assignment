using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignment
{
    public class RemainderAndQuotient
    {
        public void Division_Problem()
        {
            Console.WriteLine("Enter Dividend and Divisor value to Quotient and Remainder ");
            int dividend = Int32.Parse(Console.ReadLine()); 
            int divisor = Int32.Parse(Console.ReadLine()); 

            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

            Console.WriteLine(" Dividend : {0} and Divisor : {1} ", dividend,divisor);
            Console.WriteLine("Quotinet = " +quotient);
            Console.WriteLine("Remaider = " +remainder);

        }
    }
}
