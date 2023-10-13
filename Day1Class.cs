using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

//This is my first C# program
/* Multiple comments*/

namespace TrainingSEP20
{
    class Day1Class
    {
        static void Main(string[] args)
        {
            int Num1 = 5, Num2 = 10;
            float Float2 = 3.4F;
            decimal Dec1 = 5.1M;
            bool x = true, y = false;
            char C1 = 'A';
            string STR1 = "This is C# ";
            double dbl = 20.6d;

            string STR2 = "";
            int a = 55;
            long b = a;

            int v = (int)b;

            Console.WriteLine("Hello, I am Sreedevi Rajalekshmy");
            Console.Write(Num1+Num2+Float2 );
            Console.WriteLine(" "+x);
            Console.WriteLine(STR1 + "Which is ");

            Console.WriteLine(a + b);
            Console.ReadLine();
        }

    }
    
}
