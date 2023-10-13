using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSEP20
{
    internal class Day12_Exception2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 numbers to divide: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            try
            {
                int Quot = num1 / num2;
                int remain = num1 % num2;
                Console.WriteLine("Quotient= " + Quot);
                Console.WriteLine("Remainder= " + remain);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }
    }
}
