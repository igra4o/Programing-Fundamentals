using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int multiplier = 1;
            while (multiplier <= 10)
            {
                int product = n * multiplier;
                Console.WriteLine(n + " X " + multiplier + " = " + product);
                multiplier++;
            }
        }
    }
}
