using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSEP20
{
    internal class Day10_AbstractClass3 : Day10_AbstractClass2
    {
        public override void animal(string str2)
        {
            Console.WriteLine("Animal from second child "+str2);
        }

       /* public void birds(string str)
        {
            Console.WriteLine("Birds from second child  "+ str);
        }*/
        public override void flowers()
        {
            Console.WriteLine("This is Flowers from second child");

        }
    }
}
