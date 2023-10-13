using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSEP20
{
    internal class Day13_AL_ObjType
    {
        /*Write a program that creates an ArrayList and adds 5 objects of different types (e.g., int, string, bool) to it. 
         * Then, iterate over the ArrayList and display the type of each object.*/
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            //Console.WriteLine("How many objects to be stored? ");
            //nt cnt=Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter the list elements - ");
            /*for(int i=0;i<cnt;i++)
            {
                al.Add(Console.ReadLine());
            }*/
            al.Add("50");
            al.Add(45);
            al.Add('z');
            al.Add(true);
            al.Add(16.45);

            Console.WriteLine("Elements in the array list and its type : ");
            for (int j=0; j<al.Count;j++)
            {
                Console.WriteLine(al[j]+" - " + al[j].GetType());

            }

            


        }
       


    }
}
