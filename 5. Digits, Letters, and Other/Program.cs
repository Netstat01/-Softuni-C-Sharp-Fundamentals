using System;
using System.Diagnostics;
using System.Text;

namespace _5._Digits__Letters__and_Other
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();

            StringBuilder digits = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder others = new StringBuilder();

            foreach (var item in text)
            {
                if (char.IsDigit(item))
                {
                    digits.Append(item);
                }
                else if (char.IsLetter(item))
                {
                    letters.Append(item);
                }
                else
                {
                    others.Append(item);
                }
            }
            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(others);
        }
    }
}
