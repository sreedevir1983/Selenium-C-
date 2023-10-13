using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSEP20
{
    class Day6_Method
    {
        static void add()
        {
            int a = 100, b = 200, sum;
            sum = a + b;
            Console.WriteLine("Sum of " + a + " and " + b + " is " + sum);
        }

        static void subtract(int sp1, int sp2)
        {
            int diff1;
            diff1 = sp1 - sp2;
            Console.WriteLine("Difference of " + sp1 + " and " + sp2 + " is " + diff1);
        }

        int multiply(int p1, int p2)
        {
            int product;
            product = p1 * p2;
            return product;

        }
        string division(int d1, int d2)
        {
            int q1, remain;
            q1 = d1 / d2;
            remain = d1 % d2;
            Console.WriteLine("Quotient for division of " + d1 + " and " + d2 + " is " + q1);

            return Convert.ToString(remain);

        }

        static string add(int ol1, int ol2, string name1)
        {
            int ol3 = ol1 + ol2;
            string name2 = "Sreedevi";
            Console.WriteLine("This is overloaing add method-Name inside function is :  " + name1);
            return name2;
        }

        static void add(int ol1, int ol2)
        {
            int ol3 = ol1 + ol2;
            Console.WriteLine("This is overloaing add method " + ol3);

        }
        /*
        //MAIN METHOD STARTING
        */
        static void Main(string[] args)
        {
            //Add method without return and parameters
            add();

            //Subtract method without return but with parameters
            int s1 = 50, s2 = 30;
            subtract(s1, s2);

            //non static product method with return and with parameters
            int a1 = 5, a2 = 10, product1;
            Day6_Method prod = new Day6_Method();

            product1 = prod.multiply(a1, a2);
            Console.WriteLine("Product of " + a1 + " and " + a2 + " is " + product1);

            //non static Division method with value return as string and with parameters
            int divident = 256, divisor = 3;
            string remainder;
            Day6_Method divid = new Day6_Method();

            remainder = divid.division(divident, divisor);
            Console.WriteLine("Remainder of division of " + divident + " and " + divisor + " is " + remainder);

            //method overloading for add method
            int o1 = 10, o2 = 20;
            string name = "Ameyaa";
            string newname = Convert.ToString(add(o1, o2, name));
            Console.WriteLine(newname);
            //method overloading for add method
            int x1 = 10, x2 = 20;
            add(x1, x2);

           Checking.check();
           /*public static void test()
            {
                Console.WriteLine("method inside Main");
            }*/
        }
    }

    class Checking
    {
        /*static void Main()
        {
            Console.WriteLine("Second Main");
        }
        */
        //Day6_Method ob1 = new Day6_Method;
        public static void check()
        {
            Console.WriteLine("Without second Main");
        }
       // Day6_Method.test();

    }
}
