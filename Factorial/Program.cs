using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ComputeFactorial(4));
        }

        static int ComputeFactorial(int num)
        {
            int factorial = 1;
            int counter = 1;
            while (counter <= num)
            {
                factorial = factorial * counter;
                counter++;
            }
            return factorial;
        }
    }
}
