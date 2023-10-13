using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSEP20
{
    internal class Day13_ArrayList_String
    {
        /*Write a program that creates an ArrayList and adds 5 strings to it. 
          Then, remove the second element from the ArrayList and display the updated contents.
         */
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            Console.WriteLine("How many strings to be stored? ");
            int cnt = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the strings - ");

            for(int i=0;i<cnt;i++)
            {
                al.Add(Console.ReadLine());
            }
            Console.WriteLine("Strings stored in Arraylist are: ");
            for (int j=0; j<cnt;j++)
            {
                Console.WriteLine(al[j]);
            }

            //remove second element
            al.RemoveAt(1);

            Console.WriteLine("Updated list of Strings after removal: ");
            /*for (int j = 0; j < al.Count; j++)
            {
                Console.WriteLine(al[j]);
            }*/
            foreach(string j in al)
            {

                Console.WriteLine(j);
            }
        }
    }
}
