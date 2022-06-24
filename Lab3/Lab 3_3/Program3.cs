using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborat3._3
{
    class Program3
    {
        static void Main(string[] args)
        {

            int[] numbers = { 17, 3, 4, 23, 156, 8, 1, 995 };
            Console.WriteLine("Початковий масив чисел: ");
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine(" ");

            var sortnumbers = numbers.Where(number => number % 2 == 1).OrderBy(number => number.ToString());
            Console.WriteLine("Впорядкований масив чисел: ");
            foreach (int number in sortnumbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine(" ");
        }
    }
}
