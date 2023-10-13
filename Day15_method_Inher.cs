using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSEP20
{
    internal class Day15_method_Inher : Day15_CarProperties
    {
        string model;

         void getdetails()
        {
            Console.WriteLine("Enter Car, model and its Color");
            car = Console.ReadLine();//"Ford";
            model = Console.ReadLine(); ;
            Color = Console.ReadLine(); ;
        }
        static void Main()
        {
            Day15_method_Inher ob1 =new Day15_method_Inher();
            ob1.getdetails();

            Console.WriteLine(ob1.car);
            Console.WriteLine(ob1.Color);
            Console.WriteLine(ob1.model);

        }
    }
}
