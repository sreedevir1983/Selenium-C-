using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSEP20
{
    public class Day8_Class_Objects
    {
        string name="Sreedevi";
        int i, j;

        public void add()
        {
            i = 10; j = 20;
            int sum = i + j;
            Console.WriteLine(sum);
        }
        public static void mul()
        {
            int a = 10, b = 20;
            int prod = a * b;
            Console.WriteLine(prod);
        }
        Day8_Class_Objects(int j)
        {
            i = 100;
            //j = 200;
        }
        static void Main(string[] args)
        {
            Day8_Class_Objects O1 = new Day8_Class_Objects(50);
            Console.WriteLine(" Starting point");
            O1.add();

            Day8_Class_Objects O2 = new Day8_Class_Objects(500);
            mul();

            testclass p1 = new testclass();
            p1.test();
            Console.WriteLine(p1.num);
            testclass1 p2 = new testclass1();
            p2.test1();

            Console.WriteLine("j= "+(++O2.j));
            testclass2();
        }
        
    }

    class testclass
    {
        public void test()
        {
            Console.WriteLine("Test class "+num);
        }
        public int num=500;
        
    }
     class testclass1 
    {
        internal void test1()
        {
            Console.WriteLine("My Test");
        }
        protected string text1 = "Test string";

    }

    class testclass2 : testclass1
    {
        testclass2 tex = new testclass2();
        void text()
        {
            Console.WriteLine("Inherited string "+text1);
        }
    }
}
