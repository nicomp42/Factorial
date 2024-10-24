/*
*Name: Derick Bellofatto
*email:  Bellofdk@mail.uc.edu
*Assignment Number: Assignment inClassFactorial
*Due Date: 10/24/2024
*Course #/Section:   IS 3050 - 001
* Semester / Year:   Fall 2024
*Brief Description of the assignment:  Create Factorial module based on psudo code change request

*Brief Description of what this module does: Prompts for a user's number, then calculates the number's Factorial
*Citations: Original ~ https://github.com/nicomp42/Factorial
*Anything else that's relevant:
*/
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
            //Prompts for User input
            Console.WriteLine("Input a number for factorial: ");
            //User input parsed into an integer
            int FactorialInput = int.Parse(Console.ReadLine());
            //Writing the computed value
            Console.WriteLine(ComputeFactorial(FactorialInput));

        }
        /// <summary>
        /// Calculates the factorial of a variable declared in the main module
        /// </summary>
        /// <param name="num">Number which the factorial should be calculated from</param>
        /// <returns></returns>
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
