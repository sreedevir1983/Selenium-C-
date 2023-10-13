using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSEP20
{
    internal class Day14_ArraySum
    {
        int Sumarray(int[] num, int n)
        {
            int sum = 0;
            Console.WriteLine("Enter the array elements: ");

            for (int i = 0; i < n; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
                sum = sum + num[i];
            }
            return (sum);
        }

        static void maxArray(int[] num)
        {
            Console.WriteLine("Largest number in the array: " + num.Max());
        }
        static void Main(string[] args)
        {
            Day14_ArraySum obj1 = new Day14_ArraySum();
            int[] num;
            int ArraySum=0;

            Console.WriteLine("Enter number of integers in the array: ");
            int n=Convert.ToInt32(Console.ReadLine());

            num = new int[n];

            ArraySum=obj1.Sumarray(num,n);
            
            Console.WriteLine("Sum of Array elements: "+ArraySum);

            maxArray(num);
            
            Console.WriteLine("Smallest number in the array: " + num.Min());

        }
    }
}