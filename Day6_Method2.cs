using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSEP20
{
    class Day6_Method2
    {

        static void add(int a1, int a2)
        {
            Console.WriteLine("Sum of the numbers: "+(a1+a2));

        }
        static void subtract(int a1, int a2)
        {
            Console.WriteLine("Difference of the numbers: " + (a1 - a2));

        }
        static void multiply(int a1, int a2)
        {
            Console.WriteLine("Product of the numbers: " + (a1 * a2));

        }
        static void divide(int a1, int a2)
        {
            Console.WriteLine("Quotient of the division: " + (a1 / a2));
            Console.WriteLine("Remainder of the division: " + (a1 % a2));
        }
        static void Main()
        {
            int num1, num2;
            Console.WriteLine("Enter 2 numbers: " );
            num1=Convert.ToInt32(Console.ReadLine());
            num2= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Select the required option from the below list: ");
            Console.WriteLine("1-Add");
            Console.WriteLine("2-Subtract");
            Console.WriteLine("3-Multiply");
            Console.WriteLine("4-Divide");
            int opt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You have selected the option "+opt);
            switch (opt)
            {
                case 1:
                    add(num1,num2);
                    break;
                case 2:
                    subtract(num1,num2);
                    break;
                case 3:
                    multiply(num1, num2);
                    break;
                case 4:
                    divide(num1, num2);
                    break;
                default:
                    break;
            }

        }
    }
}
