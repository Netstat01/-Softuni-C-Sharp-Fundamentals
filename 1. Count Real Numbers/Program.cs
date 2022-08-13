using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<double, int> counts = new SortedDictionary<double, int>();

            double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();

            foreach (var item in input)
            {
                if (counts.ContainsKey(item))
                {
                    int currentOccurence = counts[item];

                    counts[item]++;                    
                }
                else
                {
                    counts.Add(item,1);
                }
            }
            counts.ToList().ForEach(x => Console.WriteLine($"{x.Key} -> {x.Value}"));            
        }
    }
}
