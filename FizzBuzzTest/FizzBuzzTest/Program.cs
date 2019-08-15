using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            while (n <= 100)
            {
                bool a = n % 3 == 0;
                bool b = n % 5 == 0;

                if (a && b)
                {

                    Console.WriteLine("FizzBuzz");
                }
                else if (a)
                {
                    Console.WriteLine("Fizz");
                }
                else if (b)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(n);
                }

                n++;
            }

            Console.ReadLine();

        }
    }
}
