using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSEP20
{
    internal class Interface_Class1 : Interface1
    {
        int a, b;

        public void getnumbers()
        {
            Console.WriteLine("Enter 2 numbers: ");
            a=Convert.ToInt32(Console.ReadLine());
            b=Convert.ToInt32(Console.ReadLine());
                
        }
        public void add()
        {
            Console.WriteLine("Sum of "+a+" and "+b+" is "+(a+b));

        }
        public void sub()
        {
            Console.WriteLine("Difference of 2 numbers " + a + " and " + b + " is " + (a - b));
        }
        
        
    }
}
