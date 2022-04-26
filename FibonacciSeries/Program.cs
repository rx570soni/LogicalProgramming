using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace FibonacciSeries
{
    class Program
{
        static int Fibonacci(int n)
        {
          
            if (n == 0) return 0; 
            if (n == 1) return 1; 
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        static void Main(string[] args)
        {
            Console.Write("Length of the Fibonacci Series: ");

            int length = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < length; i++)
            {
                Console.Write("{0} ", Fibonacci(i));
            }
            Console.ReadKey();
        }
    }
}