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

            Console.WriteLine("{0}, the solution to problem 1 is {1} ", userName, getSum());
            Console.WriteLine("{0}, the solution to problem 2 is {1} ", userName, getFiboSum());
            Console.WriteLine("Press any key to quit.");
            Console.ReadKey();
        }

        static int getSum()
        {
            int sum = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }

        static int getFiboSum()
        {
                int a, b, c;
                int numLim = 0;
                a = 1;
                b = 2;
                int sum = 0;

                while (numLim < 4000000)
                {
                    c = a + b;
                    a = b;
                    b = c;
                    numLim = b;
                    if (numLim > 4000000)
                    {
                        break;
                    }
                    if (numLim % 2 == 0)
                    {
                        sum = sum + numLim;
                    }
                }
                return sum;
            }

        }
    }

