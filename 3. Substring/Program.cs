using System;
using System.Linq;

namespace _3._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string secondInput = Console.ReadLine();

            while (secondInput.Contains(input))
            {              
                secondInput = secondInput.Replace(input, string.Empty);
            }
            Console.WriteLine(secondInput);
        }
    }
}
