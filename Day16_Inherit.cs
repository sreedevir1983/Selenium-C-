using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSEP20
{
    /*Object-Oriented Programming (OOP)
    a.Define a class representing a simple car with properties and methods.
    b.Implement inheritance by creating a base class and a derived class.*/

    internal class Day16_Inherit
    {
        public string first;
        protected string last;
        
        protected string getname(string f, string l)
        {
            string full = f +" "+ l;
            return (full);
        }
    }

    class stud : Day16_Inherit
    {
        stud()
        {
            first = Console.ReadLine();
            last = Console.ReadLine();
        }
        static void Main()
        {
            Console.WriteLine("Enter first name and last name: ");
            stud o1 = new stud();                       
          
            string fullname = o1.getname(o1.first, o1.last);
            
            Console.WriteLine("Full name is : " + fullname);
        }
    }
}
