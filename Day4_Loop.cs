using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSEP20
{
     class Day4_Loop
    {
        static void Main(string[] args)
        {
            //accept string
            Console.WriteLine("Enter a Statement: ");
            string STR1=Console.ReadLine();

            //length of the string
            int StrLen = STR1.Length;
            Console.WriteLine("Length of the String is " + StrLen);

           //print each alphabet of input string 
           int j = 0;
           while (j<StrLen)
             {
                 Console.WriteLine(STR1[j]);
                 /*if (STR1[j] == ' ')
                 {
                     break;
                 }*/
                 j++;

             }

            //Reverse of the string
            Console.WriteLine();
            int rev = StrLen - 1;
            do
            {
                Console.Write(STR1[rev]);
                rev--;
            } while (rev >= 0);
            
            Console.WriteLine();
            Console.WriteLine();

            //Nested loop - String pattern
            for (int x=0;x<StrLen;x++)
            {

                string newstr1 = "";
                for (int y=0;y<=x;y++)
                {
                    
                    char char1 = STR1[y];
                    string newstr = char1.ToString();    
                    newstr1 = string.Concat(newstr1, newstr);
                }
                Console.Write(newstr1);
                Console.WriteLine();

            }

            //Nested loop - Matrix
            Console.WriteLine();
            for (int p=1;p<=5;p++)
            {
                for (int q=1;q<=p;q++)
                {
                    Console.Write(q +" " );
                }
                Console.WriteLine();
            }

        }
    }
}
