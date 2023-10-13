using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSEP20
{
    internal class Day12_Rectangle
    {
        private int lengt, width;

        Day12_Rectangle()
        {
            lengt = 0;
            width = 0;

        }
        Day12_Rectangle(int l,int w)
        {
            lengt = l;
            width = w;

        }
        int CalculateArea(int len, int wid)
        {
            int area = len * wid;
            return area;
        
        }
        int CalculateArea()
        {
            Console.WriteLine("Enter the side of the square: ");
            lengt = Convert.ToInt32(Console.ReadLine());
            width = lengt;
            
            int area = lengt * width;
            return area;

        }
        static void Main()
        {
            Day12_Rectangle obj1 = new Day12_Rectangle();

            Console.WriteLine("Enter length and width of the Rectangle: ");
            int len = Convert.ToInt32(Console.ReadLine());
            int wid = Convert.ToInt32(Console.ReadLine());

            Day12_Rectangle obj2 = new Day12_Rectangle(len,wid);
            //Rectangle
            int RecArea = obj2.CalculateArea(obj2.lengt, obj2.width);
            Console.WriteLine("Area of Rectangle: " + RecArea);

            //Square
            int SqArea =obj1.CalculateArea();
            Console.WriteLine("Area of Square: "+SqArea);

            
        }
    }
}
