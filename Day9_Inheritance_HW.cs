using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSEP20
{
    class addint : Day9Class_Inheritance
    {
        int num1 = 30, num2 = 50;
        void addition()
        {
            Console.WriteLine("This is addint class "+(num1+num2));
        }
        /*static void Main(string[] args)
        {
            addint obj2 = new addint();
            obj2.addition();
        }*/
    }
}
