using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day5Assignment
{
    public class program
    {
        void FlipCoin()
        {
            Console.WriteLine("Enter How many times to flip coin");
            double n = Double.Parse(Console.ReadLine());


            int h_count = 0;
            int t_count = 0;

            for(int i = 1;i <= n;i++)
            {
                Random random = new Random();
                int head_or_tail = random.Next(0, 2);
                if (head_or_tail == 1)
                {
                    Console.WriteLine("Heads"); 
                    h_count++;
                }
                else
                {
                    Console.WriteLine("Tails");
                    t_count++;
                }
            }
            Console.WriteLine("no of heads "+h_count);
            Console.WriteLine("no of tails "+t_count);

            double Head_percentage = (h_count/n)*100 ;
            double Tail_Percentage = (t_count/n)*100;

            Console.WriteLine("Percentage of Heads is = {0}%",Head_percentage);
            Console.WriteLine("Percentage of Tails is = {0}% ", Tail_Percentage);

        }

        void Leap_Year()
        {
            Console.WriteLine("Enter Year in format of yyyy");
            int year = Int32.Parse(Console.ReadLine());

            if(((year % 4==0) && (year % 100 !=0)) || (year % 400 == 0))
            {
                Console.WriteLine("{0} is a leap year");
            }
            else
            {
                Console.WriteLine("{0} is not a leap year");
            }
        }

        void Pow_2()
        {
            Console.WriteLine("Enter  any positive number to know power of 2");
            int power = Int32.Parse(Console.ReadLine());
            Console.WriteLine("your find 2 power {0}",power);
            double pow_ab = 0;



            for (int i = 1; i <= power; i++)
            {
                pow_ab = Math.Pow(2, power);
            }

            Console.WriteLine("the power of 2 is " + pow_ab);
        }



        public static void Main(string[] args)
        {
           program obj = new program();


            Console.WriteLine("Flip coin problem");
            obj.FlipCoin();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Leap Year Problem");
            obj.Leap_Year();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Powers of 2 problem");
            obj.Pow_2();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Harmonic Problem");
            
            Harmonic obj2 = new Harmonic();
            obj2.Harmonic1();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Prime Factorization");
            PrimeFactor obj3 = new PrimeFactor();
            obj3.Prime();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("To Find Quotient and Remainder divison should be done");
            RemainderAndQuotient obj4 = new RemainderAndQuotient();
            obj4.Division_Problem();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Swapping of Two Numbers");
            SwapTwoNumbers obj5 = new SwapTwoNumbers();
            obj5.Swapping();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Whether to find given number is even or odd");
            EvenOrOdd evenOrOdd = new EvenOrOdd();
            evenOrOdd.Even_Or_Odd();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Enter a alphabet to check it is Vowel or not");
            Alphabet alphabet = new Alphabet();
            alphabet.Vowels();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Enter a Three numbers to find largest among three given numbers");
            LargerNumber largerNumber = new LargerNumber();
            largerNumber.Largest();

        }
    }
}