using System;

namespace _2._Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            foreach (var item in input)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    Console.Write(item);
                }
            }
        }
    }
}
