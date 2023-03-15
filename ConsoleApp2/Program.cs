using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;


namespace Pz1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 5000;
            int[] a = new int[n];
            List<int> b = new List<int>();
            Random rnd = new Random();
            int y = rnd.Next(0, 5000);
            Hashtable c = new Hashtable();
            for (int i = 0; i < n; i++)
            {
                a[i] = rnd.Next(0,5000);
                b.Add(a[i]);
                c.Add(i, a[i]);

            }
            Stopwatch stpWatch = new Stopwatch();
            stpWatch.Start();
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
            stpWatch.Start();
            for (int i = 0; i < n; i++)
            {
                if (b[i] == y)
                {
                    Console.WriteLine("Число найдено");
                    break;
                }
            }
            stpWatch.Stop();
            Console.WriteLine($"StopWatch:{stpWatch.ElapsedMilliseconds.ToString()}");

        //    stpWatch.Start();
        //    SearchBinary(a);
        //    stpWatch.Stop();
        //    Console.WriteLine($"StopWatch:{stpWatch.ElapsedMilliseconds.ToString()}");
        //}
        //static void SearchBinary (int[] a) 
        //{
        //    int N = a.Length; 
        //    for (int i = 1; i <= N-1; i++) 
        //    { 
        //        int tmp = a[i], left = 1, right = i-1; 
        //        while (left <= right) 
        //        { 
        //            int m = (left+right) / 2; //определение индекса среднего элемента
        //            if (tmp<a[m]) 
        //                right=m-1; // сдвиг правой или
        //            else 
        //                left=m+1; // левой граничы
        //        } 
        //        for (int j = i-1; j >= left; j--) 
        //            a[j+1] = a[j]; // сдвиг злемеHTOB // размещение элемента в нужном месте
        //        a[left]=tmp; 
        //    }

        }

    }
}
