using System;

namespace _8.__Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            double sum = 0;

            foreach (var item in input)
            {
                char firstLetter = item[0];
                char lastLetter = item[item.Length - 1];

                double number = double.Parse(item.Substring(1, item.Length - 2));
                double result = 0;

                
                

                if (firstLetter >= 65 && firstLetter <= 90)
                {
                    int firstLetterInTheAlphabet = firstLetter - 64;
                    result = number / firstLetterInTheAlphabet;
                }
                else
                {
                    int firstLetterInTheAlphabet = firstLetter - 96;
                    result = number * firstLetterInTheAlphabet;
                }

                if (lastLetter >= 65 && lastLetter <= 90)
                {
                   int lastLetterInTheAlphabet = lastLetter - 64;
                    sum += result - lastLetterInTheAlphabet;
                }
                else
                {
                    int lastLetterInTheAlphabet = lastLetter - 96;
                    sum += result + lastLetterInTheAlphabet;
                }
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
