using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name:");
            string userName = Console.ReadLine();

            Console.WriteLine("Hello, {0} the current time is {1}", userName, System.DateTime.Now.TimeOfDay);

            Console.WriteLine("Press any key to quit.");
            Console.ReadKey();
        }
    }
}
