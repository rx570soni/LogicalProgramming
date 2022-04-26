using System;

namespace StopWatch
{
    class Program
    {
       
        public static void Main() 
        {
            var watch = new System.Diagnostics.Stopwatch();
            Console.WriteLine("please press 0 to start ");
            int i = int.Parse(Console.ReadLine());
            if (i == 0) watch.Start();
            
            Console.WriteLine("please press 1 to stop ");
            i = int.Parse(Console.ReadLine());
            
            if (i == 1) watch.Stop();

            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");

        }
    }
}