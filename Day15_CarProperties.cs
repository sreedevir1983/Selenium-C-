using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSEP20
{
    internal class Day15_CarProperties
    {
        private string name, color;
        public string car
        {
            get{ return name; }
            set{ name = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
    }

    /*class car
    {
        static void Main(string[] args)
        {
            Day15_CarProperties n = new Day15_CarProperties();
            n.car = "Maruthi";
            n.Color = "Blue";

            Console.WriteLine(n.car);
            Console.WriteLine(n.Color);
        }
    }
    */
}
