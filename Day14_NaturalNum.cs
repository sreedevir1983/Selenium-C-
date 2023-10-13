using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSEP20
{
    internal class Day14_NaturalNum
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of Natural numbers required: ");
            int n=Convert.ToInt32(Console.ReadLine());
            int num = 0;
            for (int i=1; i<=n;i++)
            {
                Console.WriteLine(i);
            }

        }
    }
}
