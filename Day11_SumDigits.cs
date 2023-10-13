using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSEP20
{
    internal class Day11_SumDigits
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            string str1 = Console.ReadLine();
            int strLen = str1.Length;
            Console.WriteLine("Length of the number: "+strLen);

            int number = Convert.ToInt32(str1);
            int digitSum=0, modu=0, quot, mod;
            
            quot = number;

            for (int i=1;i<=strLen;++i)
            {
                //Console.WriteLine(quot + "  " + modu + " " + digitSum);
                mod = quot;
                quot = quot / 10;
                modu = (mod % 10);
                digitSum = digitSum + modu;
                //Console.WriteLine(quot+"  "+modu+" "+digitSum);
            }
            Console.WriteLine("Sum of the digits of the number: "+ digitSum);

        }
    }
}
