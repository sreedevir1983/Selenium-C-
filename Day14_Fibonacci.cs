using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSEP20
{
    internal class Day14_Fibonacci
    {
        static void Main()
        {
            Console.WriteLine("Enter the Fibonacci number limit: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 0,j = 1,k=0;
            
            Console.WriteLine(i);
            Console.WriteLine(j);

            while (k < n)
            {
                k = i + j;
                if (k < n)
                {
                    Console.WriteLine(k);
                    i = j;
                    j = k;
                }
                else 
                {
                    break;
                }
            } 

        }
    }
}
