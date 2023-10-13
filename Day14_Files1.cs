using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSEP20
{
    internal class Day14_Files1
    {
        static void Main()
        {
            string path = @"C:\Users\srrajale\source\repos\Training_SEP20\Training_SEP20\Day14_Files\Sree1.txt";
            //FileStream fs = File.Create(path);
            
            if(File.Exists(path))
            {
                File.WriteAllText(path,"Hi, I am Sreedevi ");
            }
            else
            {
                Console.WriteLine("File does not exist!");
            }
            string filetext = File.ReadAllText(path);
            Console.WriteLine(filetext);

            File.AppendAllText(path,"\n My Project is Evolution \n Personal details: \n Location \t Trivandrum \n Company \t RM.");
            filetext = File.ReadAllText(path);
            Console.WriteLine("Updated file content: "+filetext);
        }
    }
}
