using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TrainingSEP20
{
    class Day2Class
    {
        static void Main(string[] args)
        {
            /*
                   //Constants
                   const int Interest = 10;
                   int Interest11 = 20;
                   Console.WriteLine(Interest+Interest11);
                   string name, role;

                   //Read from Console
                   Console.WriteLine("Enter your name: ");
                   name = Console.ReadLine();
                   Console.WriteLine("Enter your role: ");
                   role = Console.ReadLine();
                   Console.WriteLine(name + " is a "+role);
                   //xx is a yy

            */
            //Typecasting
            int abc = 923467890;
            long def = abc; //implicit

            long xyz = 9999888877776666;
            int pqr = (int)xyz; //explicit

            Console.WriteLine(abc + ", " + def + " ," + xyz + ", "+pqr);
            //923467890, 923467890 ,9999888877776666, -1873121510
        /*
            //Operators
            int num1 = 6;
            int num2 = 4;

            Console.WriteLine("Sum of " + num1 + " and " + num2 + " is " + (num1+num2));
            Console.WriteLine("Difference of " + num1 + " and " + num2 + " is " + (num1 - num2));
            Console.WriteLine("Product of " + num1 + " and " + num2 + " is " + (num1 * num2));
            Console.WriteLine("Quotient of Division " + num1 + " and " + num2 + " is " + (num1 / num2));
            Console.WriteLine("Remainder of Division " + num1 + " and " + num2 + " is " + (num1 % num2));
            //Strings
        */
        }
    }
}
