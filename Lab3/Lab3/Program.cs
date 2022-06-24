using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace Laborat3
{
    class Program1
    {
        public static void PrintValues(IEnumerable numbers)
        {
            foreach (Object obj in numbers)
                Console.Write(" " + obj);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть кiлькiсть людей у крузi: ");
            int n = Convert.ToInt32(Console.ReadLine());
            var numbers = new ArrayList();
            for (int i = 1; i <= n; i++)
            {
                numbers.Add(i);
            }
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Console.WriteLine("Наш круг людей:");
            PrintValues(numbers);
            Console.WriteLine("\nВидаляється кожний другий...");

            while (numbers.Count != 1)
            {
                int i = 1;
                n = numbers.Count;
                while (i < numbers.Count)
                {
                    numbers.RemoveAt(i);
                    PrintValues(numbers);
                    i++;

                }
                if (n % 2 == 1)
                {
                    numbers.RemoveAt(0);
                    PrintValues(numbers);
                }
            }


            /* stopWatch.Stop();
             TimeSpan ts = stopWatch.Elapsed;
             string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
           ts.Hours, ts.Minutes, ts.Seconds,
           ts.Milliseconds / 10);
             Console.WriteLine("RunTime " + elapsedTime);*/


            /*
                        Console.WriteLine("Введiть кiлькiсть людей у крузi: ");
                        int n = Convert.ToInt32(Console.ReadLine());
                        LinkedList<string> numbers = new LinkedList<string>();
                        for (int i = 1; i <= n; i++)
                        {
                            numbers.AddLast($"{i}");
                        }
                        Stopwatch stopWatch = new Stopwatch();
                        stopWatch.Start();
                        Console.WriteLine("Наш круг людей:");

                        Console.WriteLine("\nВидаляється кожний другий...");
                        for (int i = 1; i < numbers.Count; i++)
                        {
                            numbers.Remove(numbers.ElementAt(i));
                            n = i;
                        }
                        while (numbers.Count != 1)
                        {
                            if (n == numbers.Count)
                            {
                                for (int k = 1; k < numbers.Count; k++)
                                {
                                    numbers.Remove(numbers.ElementAt(k));
                                    n = k;
                                }
                            }
                            if (n == numbers.Count - 1)
                            {
                                for (int k = 0; k < numbers.Count; k++)
                                {
                                    numbers.Remove(numbers.ElementAt(k));

                                    n = k;
                                }
                            }
                        }
                        PrintValues(numbers);
                        stopWatch.Stop();
                        TimeSpan ts = stopWatch.Elapsed;
                        string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                      ts.Hours, ts.Minutes, ts.Seconds,
                      ts.Milliseconds / 10);
                        Console.WriteLine("RunTime " + elapsedTime);*/

        }
    }
}
