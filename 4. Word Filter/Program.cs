using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Word_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().
                Split().
                Where(x => x.Length % 2 == 00).ToArray();

            foreach (var item in input)
            {
                Console.WriteLine(item);
            }

            
        }
    }
}
