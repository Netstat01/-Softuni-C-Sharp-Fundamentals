using System;

namespace _1._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();            

            while (input != "end")
            {
                string print = null;
                for (int i = input.Length - 1; i >= 0 ; i--)
                {
                    print += input[i];
                } 

                Console.WriteLine($"{input} = {print}");
                input = Console.ReadLine();               
            }
        }
    }
}
