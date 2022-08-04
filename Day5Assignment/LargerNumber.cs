using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignment
{
    public class LargerNumber
    {
        public void Largest()
        {
            Console.WriteLine("Enter Three Numbers ");
            int num1, num2, num3;
            num1 = Int32.Parse(Console.ReadLine());
            num2 = Int32.Parse(Console.ReadLine());
            num3 = Int32.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("The 1st Number is the greatest among three. \n\n");
                }
                else
                {
                    Console.Write("The 3rd Number is the greatest among three. \n\n");
                }
            }
            else if (num2 > num3)
            {
                Console.Write("The 2nd Number is the greatest among three \n\n");
            }
            else
            {
                Console.Write("The 3rd Number is the greatest among three \n\n");
            }
        }


    }
    
}
