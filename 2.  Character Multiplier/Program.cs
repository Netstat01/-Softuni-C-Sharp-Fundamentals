using System;

namespace _2.__Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split();
            Console.WriteLine($"{StrSum(input)}");
            
        }

        private static int StrSum(string[] input)
        {
            string longest = " ";
            string shortest = " ";
            int sum = 0;

            if (input[0].Length > input[1].Length)
            {
                longest = input[0];
                shortest = input[1];
            }
            else
            {
                longest = input[1];
                shortest = input[0];
            }

            for (int i = 0; i < shortest.Length; i++)
            {
                sum += longest[i] * shortest[i];
            }

            for (int i = shortest.Length ; i < longest.Length; i++)
            {
                sum += longest[i];
            }

            return sum;
            
        }
    }
}
