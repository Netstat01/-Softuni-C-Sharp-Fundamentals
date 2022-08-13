using System;
using System.Collections.Generic;

namespace _2._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resorces = new Dictionary<string, int>(); 
            string input = Console.ReadLine();
            string resorce = " ";
            int countity;
            int count = 1;
            while (input != "stop")
            {
                
                if (count % 2 == 1)
                {
                     resorce = input;
                    if (!resorces.ContainsKey(resorce))
                    {
                        resorces.Add(resorce, 0);
                    }
                }
                if (count % 2 == 0)
                {
                    countity = int.Parse(input);
                    if (resorces.ContainsKey(resorce))
                    {
                        resorces[resorce] += countity; 
                    }
                }
                input = Console.ReadLine();
                count++;

            }
            foreach (var item in resorces)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
