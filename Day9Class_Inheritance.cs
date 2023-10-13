using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSEP20
{
    class Day9Class_Inheritance
    {
        int num1, num2, sum;
        public void addition()
        {
            Console.WriteLine("Enter two numbers: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());

            sum = num1 + num2;
            Console.WriteLine("Sum of "+num1+" and "+num2+" is "+sum);

        }
        /*static void Main()
        {
            Day9Class_Inheritance obj1 = new Day9Class_Inheritance();
            obj1.addition();
            
        }
        */
    }

}
