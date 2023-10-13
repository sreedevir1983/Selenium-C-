using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSEP20
{
    internal class Day15_Factorial
    {
        int num, fact;
        Day15_Factorial()
        { 
        
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int num=Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            for (int i=1;i<=num;i++)
            {
                fact*= i;
                
            }
            Console.WriteLine("Factorial is: " + fact);
        }
    }
}
