
using System;
namespace demo
{
    public class Program
    {

     
            public static void toPrint<T>(T[] inputArray)
            {
                foreach (var element in inputArray)
                {
                    Console.WriteLine(element);
                }
                Console.WriteLine("----------------------------------");
            }

            public static void toPrint(int[] inputArray)
            {
                foreach (double element in inputArray)
                {
                    Console.WriteLine(element);
                }
                Console.WriteLine("----------------------------------");
            }

            public static void toPrint(double[] inputArray)
            {

                foreach (double element in inputArray)
                {
                    Console.WriteLine(element);
                }
                Console.WriteLine("----------------------------------");
            }

            public static void toPrint(char[] inputArray)
            {
                foreach (char element in inputArray)
                {
                    Console.WriteLine(element);
                }
                Console.WriteLine("-------------------------------------");
            }

        public static void Main(String[] arg)
        {
            int [] arr = { 1,2 }; 

            toPrint(arr);
        }
    }
}
    