using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to factorialize");
            int factorial = Console.Read();
            int counter = factorial;
            double total = 1;

            if (factorial > 1)
            {
                while (counter > 1)
                {
                    total *= counter;
                    counter--;
                }
            }
            Console.Write(factorial);
            Console.Write(total);

            Console.ReadLine();
        }
    }
}
