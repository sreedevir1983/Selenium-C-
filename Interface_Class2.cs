using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSEP20
{
    internal class Interface_Class2:Interface1
    {
        int p, q, r;
        public void add()
        {
            Console.WriteLine("Sum of " + p +", "+ q+" and " + r + " is " + (p + q+r));
        }
        public void sub()
        {
            Console.WriteLine("Difference of " + p + ", " + q + " and " + r + " is " + (p - (q-r)));
        }
        Interface_Class2()
        {
            p = Convert.ToInt32(Console.ReadLine());
            q = Convert.ToInt32(Console.ReadLine());
            r = Convert.ToInt32(Console.ReadLine());

        }
        static void Main(string[] args)
        {
            
            Interface_Class1 ob1 = new Interface_Class1();
            ob1.getnumbers();
            ob1.add();
            ob1.sub();

            Console.WriteLine("Enter 3 numbers: ");
            Interface_Class2 ob2 = new Interface_Class2();
            
            ob2.add();
            ob2.sub();
        }
    }
}
