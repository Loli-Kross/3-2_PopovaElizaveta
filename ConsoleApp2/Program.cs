using System;
using System.Diagnostics;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 5000;
            int[] a = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                a[i] = rnd.Next(0,5000);
            Stopwatch stpWatch = new Stopwatch();
            stpWatch.Start();
            int y = rnd.Next(0, 5000);
            for (int i = 0; i < n; i++)
            {
                if(a[i] == y)
                {
                    Console.WriteLine("Число найдено");
                    break;
                }
            }
            stpWatch.Stop();
            Console.WriteLine($"StopWatch:{stpWatch.ElapsedMilliseconds.ToString()}");
        }
    }
}
