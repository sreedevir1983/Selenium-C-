using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSEP20
{
    class Day10_AbstractContract: RM_Employees
    {
        internal override void Perm()
        {
            Console.WriteLine("");
        }
        internal override void Contract()
        {
            
            Console.WriteLine("Contract Employees do not have National Holiday allowance!");
            
        }
        static void Main()
        {
            Day10_AbstractPerm child1 = new Day10_AbstractPerm();
            char type1 = child1.get_employee();
            Day10_AbstractContract child2 = new Day10_AbstractContract();
            
            if (type1 == 'P')
            {
                child1.Perm();
            }
            else if (type1 == 'C')
            {
                child2.Contract();
            }            
            child1.events();
            
        }

    }
}
