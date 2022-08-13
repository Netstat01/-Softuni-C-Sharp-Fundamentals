using System;

namespace _4._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ");

            string text = Console.ReadLine();

            foreach (var item in bannedWords)
            {
                string replaceLenght = new string('*', item.Length);

                text = text.Replace(item, replaceLenght);
            }
            Console.WriteLine(text);
        }
    }
}
