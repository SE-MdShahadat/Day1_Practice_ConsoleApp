using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalDetailsConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, fatherName, age, phone;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                                            Personal Details                                             ");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine(" 1. What is your name?");
            Console.Write(" Answer: ");
            name=Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(" 2. What is your father name?");
            Console.Write(" Answer: ");
            fatherName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(" 3. How old are you?");
            Console.Write(" Answer: ");
            age = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(" 4. Give your contact number.");
            Console.Write(" Answer: ");
            phone = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine(" Hello! " + name +", your father name is "+fatherName);          
            Console.WriteLine(" Your age " + age+", your phone number is "+phone);          
            Console.WriteLine();          
            Console.WriteLine("      -:::-  Thank You For your information  -:::-     ");          
            Console.ReadLine();
        }
    }
}
