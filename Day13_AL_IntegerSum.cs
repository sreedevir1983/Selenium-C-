using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSEP20
{
    internal class Day13_AL_IntegerSum
    {
        /*Write a program that creates an ArrayList and adds 10 random numbers to it.
            Then, calculate and display the sum of all the numbers in the ArrayList.*/
        static void Main()
        {
            ArrayList al = new ArrayList();
            Console.WriteLine("How many numbers to be added? ");
            int cnt = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the numbers - ");
            for(int i=0;i<cnt;i++)
            {
                al.Add(Convert.ToInt32(Console.ReadLine()));
            }
            int sum=0;
            for (int j=0;j<cnt;j++)
            {
                //int num = Convert.ToInt32(al[j]);
                sum = sum + Convert.ToInt32(al[j]);
            }
            Console.WriteLine("Sum of all numbers in the arraylist : "+sum);
            
        }
    }
}
