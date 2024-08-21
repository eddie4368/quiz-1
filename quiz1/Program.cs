using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is your first name?");
                
            string firstname = Console.ReadLine();

            Console.WriteLine("what is your last name?");
            string lastname = Console.ReadLine();

            Console.WriteLine("hello " + firstname + "" + lastname);

        }
    }
}
