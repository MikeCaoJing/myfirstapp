using System;
using System.Collections.Generic;

namespace liste_and_arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> number = new List<int>();
            number.Add(4);
            number.Add(5);
            number.AddRange(number);
            number.Reverse();
            number.Sort();

            foreach (var item in number)
            {
                Console.WriteLine(item.ToString());
            }
            ;

            Console.WriteLine("Hello World!");
        }
    }
}
