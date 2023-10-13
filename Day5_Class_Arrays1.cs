using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSEP20
{
     class Day5_Class_Arrays1
    {
        static void Main(string[] args)
        {
            int[] ages, ages2;
            ages = new int[5];
            ages2 = new int[5];
            
            Console.WriteLine("Enter age: ");

            for (int i=0;i<ages.Length;i++)
            {
                string agestr = Console.ReadLine();
                ages[i] = Convert.ToInt32(agestr);
             
                ages2[i] = ages[i];
            }

            Console.WriteLine(" Ages in Second array: ");
            for (int j=0; j<ages2.Length;j++)
            {
                Console.Write(ages2[j]+ " ");

            }
            Console.WriteLine();
        }
    }
}
