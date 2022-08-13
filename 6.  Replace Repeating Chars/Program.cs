using System;
using System.Text;

namespace _6.__Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder input = new StringBuilder(Console.ReadLine());
            StringBuilder message = new StringBuilder();
            char letter = (char)input[0];
            bool isValid;


            for (int i = 0; i < input.Length; i++)
            {
                isValid = true;
                if (input[i] == letter)
                {
                    isValid = false;
                    continue;
                }
                else if (isValid)
                {
                    message.Append(letter);
                    letter = input[i];                    
                }
            }
            message.Append(letter);
            Console.WriteLine(message);
        }
    }
}
