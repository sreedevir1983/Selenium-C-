using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSEP20
{
    internal abstract class Day10_AbstractClass1
    {
        public abstract void animal(string str11);        
        public void birds()
        {
            Console.WriteLine("This is to display Birds!");
        }
        public abstract void flowers();
        static void Main(string[] args)
        {
            Console.WriteLine("This is the main method in abstract class");
            Day10_AbstractClass2 anim = new Day10_AbstractClass2();
            anim.animal("Tiger");
            anim.birds();

            Day10_AbstractClass3 bir = new Day10_AbstractClass3();
            
            bir.animal("Lion");
            string str1 = "Peacock";
            //bir.birds(str1);
            bir.flowers();
            
        }
    }
}
