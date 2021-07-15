using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemOne_IncorrectSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. The following code find the sum of all the numbers between 0 and 10000
            //2. The sum of the numbers should be for only numbers that are divisble by 3 or 5
            int result1, result2, result3;
            int n = 10000, i = 3, j = 5, k = 15; 
            result1 = ((n / i) * (2 * i + (10000 / i - 1) * i) / 2);
            result2 = ((n / j) * (2 * j + (10000 / j - 1) * j) / 2);
            result3 = ((n / k) * (2 * k + (10000 / k - 1) * k) / 2);
            Console.WriteLine("The sum of all number divisble by 3 and 5 between 1 and 10000 is "+ result);
        }
    }
}
