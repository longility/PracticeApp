using System;
using System.Collections.Generic;
using System.Linq;

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
            Console.WriteLine("{0}, the solution to problem 2 is {1} ", userName, getSumOfEvenFibNumbers());
            Console.WriteLine("{0}, the solution to problem 3 is {1} ", userName, primeNum());
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

        static int getSumOfEvenFibNumbers()
        {
            int limit = 4000000;
            int sum = 0;
            int a = 1;
            int b = 2;

            while (b < limit)
            {
                if (b % 2 == 0) sum += b;

                //temporarily storing variable technique
                int temp = a + b;
                a = b;
                b = temp;
            }

            return sum;
        }

        public static long primeNum()
        {

            long n = 600851475143L;
            List <long> numbers = new List<long>();

            for (long i = 2; i <= n; i++)
            {
                if (n % i == 0)
                {
                    numbers.Add(i);
                    n = n / i;
                    i = 2;
                }
            }
            long answer = numbers.Last();
            return answer;
        }
    }
}

