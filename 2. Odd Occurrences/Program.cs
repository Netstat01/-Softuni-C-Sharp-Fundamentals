using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> count = new Dictionary<string, int>();

            foreach (var item in input)
            {
                var wordInLowerCase = item.ToLower();

                if (count.ContainsKey(wordInLowerCase))
                {
                    count[wordInLowerCase]++;
                }
                else
                {
                    count.Add(wordInLowerCase, 1);
                }
            }
            foreach (var item in count)
            {
                if (item.Value % 2 != 0)
                {
                    Console.Write(item.Key + " ");
                }               
            }
        }
    }
}
