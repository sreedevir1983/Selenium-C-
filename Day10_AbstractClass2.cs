using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSEP20
{
    internal class Day10_AbstractClass2 : Day10_AbstractClass1
    {
        public override void animal(string str2)
        {
            Console.WriteLine("This is to display Animals!"+str2);
        }
        public override void flowers()
        {
            Console.WriteLine("This is Flowers from first child");

        }
    }

}
