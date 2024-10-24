using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ComputeFactorial(10));

        }

        static int ComputeFactorial(int num)
        {
            int Factorial = 1;
            int counter = 1;
            while (counter <= num)
            {
                Factorial = Factorial*counter;
                counter++;
                
            }
            return Factorial;

        }
    }
}
