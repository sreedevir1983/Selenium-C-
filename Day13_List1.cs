using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSEP20
{
    internal class Day13_List1
    {
        static void Main(string[] args)
        {
            /*List<int> lis = new List<int>();
            Console.WriteLine("Enter the number of elements to be stored: ");
            int lislen=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the elemnts: ");
            for(int i=0;i<lislen;i++)
            {
                lis.Add(Convert.ToInt32(Console.ReadLine()));

            }
            */
            List<string> lis = new List<string>();

            Console.WriteLine("Enter the number of elements to be stored: ");
            int lislen = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the elemnts: ");
            for (int i = 0; i < lislen; i++)
            {
                lis.Add(Console.ReadLine());
            }

            Console.WriteLine("Elements stored in the List are: ");
            foreach (string j in lis)
            {
                Console.WriteLine(j);
            }
        }
    }
}
