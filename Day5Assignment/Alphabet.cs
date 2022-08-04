using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignment
{
    public class Alphabet
    {
        public void Vowels()
        {
            Console.WriteLine("Enter an Alphabet A-Z or a-z");
            char ch = Convert.ToChar(Console.ReadLine().ToLower());

            switch(ch)
            {
                case 'a': Console.WriteLine("{0} is Vowel", ch);
                    break;
                case 'e':
                    Console.WriteLine("{0} is Vowel", ch);
                    break;
                case 'i':
                    Console.WriteLine("{0} is Vowel", ch);
                    break;
                case 'o':
                    Console.WriteLine("{0} is Vowel", ch);
                    break;
                case 'u':
                    Console.WriteLine("{0} is Vowel", ch);
                    break;
                default: Console.WriteLine("{0} is Consonent", ch);
                    break;
            }


        }
    }
}
