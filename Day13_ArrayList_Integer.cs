using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSEP20
{
    /*
     Write a program that creates an ArrayList and adds 5 different integers to it. 
    Then, display the contents of the ArrayList on the console.     
     */
    internal class Day13_ArrayList_Integer
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            Console.WriteLine("Enter how many numbers to be stored in the ArrayList: ");
            int cnt = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the numbers: ");
            for (int i=0;i<cnt;i++)
            {                
                al.Add(Convert.ToInt32(Console.ReadLine()));
            }
            
            Console.WriteLine("Array List integers are: ");
            for (int j=0;j<cnt;j++)
            {
                Console.WriteLine(al[j]);
            }
        }
    }
}
