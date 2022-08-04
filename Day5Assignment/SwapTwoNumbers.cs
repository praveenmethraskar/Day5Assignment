using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignment
{
    public class SwapTwoNumbers
    {
        public void Swapping()
        {
            Console.WriteLine("");
            Console.WriteLine("Enter Two Numbers To Swap a and b");

            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Before swap a= "+a+" b= "+b);

            a=a* b; //a=50 (5*10)      
            b=a/b; //b=5 (50/10)      
            a=a/b; //a=10 (50/5)    

            Console.Write("After swap a= "+a+" b= "+b);
        }
    }
}
