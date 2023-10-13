using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSEP20
{
    internal class Day11_StringSpaces
    {
        string getstring()
        {
            Console.WriteLine("Enter a string: ");
            string str2 = Console.ReadLine();
            return str2;
        }
        int spacecount(string str11)
        {
            int cnt = 0;
            char[] charstring = str11.ToCharArray();
            int charLen = charstring.Length;
            Console.WriteLine("Length of char array: " + charLen);

            //int count=0;
            for (int i = 0; i < charLen; ++i)
            {
                if (charstring[i] == ' ')
                {
                    ++cnt;
                }

            }
            return cnt;
        }
        static void Main(string[] args)
        {
            Day11_StringSpaces ob1 = new Day11_StringSpaces();
            string str1 = ob1.getstring();

            int count = ob1.spacecount(str1);
            
            Console.WriteLine("Number of spaces in the given string: "+count);
        
        }

    }
}
