using System;
using System.Linq;
using System.Text;

namespace _1.__Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputNames = Console.ReadLine().Split(", ");

            foreach (var item in inputNames)
            {
                bool isValid = true;
                if (item.Length > 3 && item.Length < 16)
                {
                    foreach (var letter in item)
                    {
                        if (!(char.IsDigit(letter) ||
                            char.IsLetter(letter) ||
                            letter == '-' ||
                            letter == '_'))
                        {
                            isValid = false;
                            break;
                        }
                    }
                    if (isValid)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
        }
    }
}
