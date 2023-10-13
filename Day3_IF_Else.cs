using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSEP20
{
    internal class Day3_IF_Else
    {
        static void Main(string[] args)
        {
            int number1, number2;
            string str1, str2;

            Console.WriteLine("Enter a number : ");
            str1 = Console.ReadLine();
            number1 = Convert.ToInt32(str1);

            Console.WriteLine("Enter another number : ");
            number2 = Convert.ToInt32(Console.ReadLine());
            
            //Even or Odd checking

            if (number1%2!=0)
            {
                Console.WriteLine(number1 + " is an odd number");            
            }
            else
            {
                Console.WriteLine(number1 + " is an even number");
            }
        
            //comparison of 2 numbers using Nested if--else

            if (number1 > number2)
            {
                Console.WriteLine(number1 + " is greater than " + number2);
            }
            else if (number1 < number2)
            {
                Console.WriteLine(number1 + " is less than " + number2);
            }
            else 
            {
                Console.WriteLine(number1 + " is equal to "+number2);
            }

            //ternary operator - ?:
            string str = number1 == number2 ? "both are equal" : "bothe are different";
            Console.WriteLine(str);


        }
    }
}
