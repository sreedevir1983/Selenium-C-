using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSEP20
{
    internal class Day13_Encapsulation
    {
        private string name, password;
        
        public string Fname 
        {
            set { name = value; }
            get { return name; }           
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        
    }  
        class User
        {
            static void Main(string[] args)
            {
            Day13_Encapsulation fname = new Day13_Encapsulation();
            Console.WriteLine("Enter User name: ");
            fname.Fname = Console.ReadLine();
            
            Day13_Encapsulation pass = new Day13_Encapsulation();
            pass.Password = "Abcs@123";

            Console.WriteLine("User name: "+fname.Fname);
            Console.WriteLine("Password: "+pass.Password);

            }
        }
    }

