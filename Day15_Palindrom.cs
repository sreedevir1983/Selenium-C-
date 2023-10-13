using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSEP20
{
    internal class Day15_Palindrom
    {
        string rev;
        int len; 
        string getstring()
        {
            Console.WriteLine("Enter the string: ");
            string str = Console.ReadLine();            
            return str;
        }
        string reverse(string strr)
        {
            char[] charstring = new char[len];
            charstring = strr.ToCharArray();

            for (int i = len - 1; i >= 0; i--)
            {
                rev = rev + charstring[i];
            }

            for (int k = 0; k < rev.Length; k++)
            {
                Console.Write(rev[k]);
            }
            return (rev);

        }
        void compare(string str1, string rev2)
        {
            if (str1 == rev2)
            {
                Console.WriteLine(str1 + " is a Palindrome!");
            }
            else
            {
                Console.WriteLine(str1 + " is not a Palindrome!");
            }
        }
        Day15_Palindrom()
        {            
            
        }
        Day15_Palindrom(string str1)
        {
            len = str1.Length;
            rev = "";
        }
        static void Main()
        {
            Day15_Palindrom ob1 = new Day15_Palindrom();            
            string str = ob1.getstring();

            Day15_Palindrom ob2 = new Day15_Palindrom(str);

            string rev1 = ob2.reverse(str);  
            
            Console.WriteLine();

            ob1.compare(str, rev1);            
        }        
    }
}