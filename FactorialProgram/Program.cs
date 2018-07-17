using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialProgram
{
    class Program
    {
        static int Factorial(int n)
        {
            if (n == 0) 
            {
                return 1;
            }
            else
            {
                return (n * Factorial(n - 1)); //take value and multiply out
            }
        }

        static void Main(string[] args)
        {
            int factorThis;

            Console.WriteLine("Enter number to factor:  ");
            factorThis = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(factorThis + " factored out is equal to " + Factorial(factorThis));

            Console.ReadKey();
        }
    }
}
