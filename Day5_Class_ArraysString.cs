using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSEP20
{
     class Day5_Class_ArraysString
    {
        static void Main(string[] args)
        {
            string[] days;
            days = new string[7];

            Console.WriteLine("Enter the 7 days: ");
            for(int i=0;i<days.Length;i++)
            {
                days[i] = Console.ReadLine();
            }

            Console.WriteLine("User enter a day: ");
            string userstring = Console.ReadLine();

            for (int j=0;j<days.Length;j++)
            {
                if (days[j] == userstring)
                {
                    Console.WriteLine(userstring + " found inside the array!");
                    break;
                }
                else if (j==days.Length-1)
                {
                    Console.WriteLine(userstring + " has not found inside the array!");
                }
             }
            
        }
    }
}
