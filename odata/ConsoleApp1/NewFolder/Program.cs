using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            /* array
            Console.Write("Geben Sie die gewünschte Anzahl von Werten ein: ");
            n = Convert.ToInt32(Console.ReadLine());
            
            int[] number = new int[n];

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("geben sie die Gewünschte Anzahl von Wert ein:");
                number[i - 1] = Convert.ToInt32(Console.ReadLine());

            }

            foreach (var item in number)
            {
                Console.WriteLine(item.ToString());
            }
            number = null;
            */
            // list
            List<int> number = new List<int>();
            Console.Write("Geben Sie die gewünschte Anzahl von Werten ein: ");
            n = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("geben sie die Gewünschte Anzahl von Wert ein:");
                number.Add(Convert.ToInt32(Console.ReadLine()));
            }
            foreach (var item in number)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
