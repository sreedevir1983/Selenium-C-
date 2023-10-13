using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSEP20
{
    internal class Day3Class_switch
    {
        static void Main(string[] args)
        {

            /* string alpha;
             Console.WriteLine("Enter an Alphabet: ");
             alpha = Console.ReadLine();


             switch(alpha)
                 {
                 case "a":
                     Console.WriteLine(alpha + " is a vowel");
                     break;
                 case "e":
                     Console.WriteLine(alpha + " is a vowel");
                     break;
                 case "i":
                     Console.WriteLine(alpha + " is a vowel");
                     break;
                 case "o":
                     Console.WriteLine(alpha + " is a vowel");
                     break;
                 case "u":
                     Console.WriteLine(alpha + " is a vowel");
                     break;
                 default:
                     Console.WriteLine(alpha + " is not a vowel");
                     break;
             }*/

            char ch;
            Console.WriteLine("Enter an Alphabet: ");
            ch = Convert.ToChar(Console.ReadLine());

            switch (ch)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine(ch + " is a vowel");
                    break;
                default:
                    Console.WriteLine(ch + " is not a vowel");
                    break;

            }
        }
    }
}
