using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSEP20
{
    abstract class RM_Employees
    {
        internal abstract void Perm();
        internal abstract void Contract();

        public void events()
        {
            Console.WriteLine("All EVO employees are following UK calendar");
        }
        public char get_employee()
        {
            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();
            char type;

            switch (name)
            {
                case "Sajina T":
                case "Sreedevi R":
                case "Meenu S":
                case "Meenu J":
                    Console.WriteLine(name + " is a Permanent employee!");
                    type = 'P';
                    break;
                default:
                    Console.WriteLine(name + " is a Contract employee!");
                    type = 'C';
                    break;
            }
            return type;
        }


    }
}
