using System;
using System.Collections.Generic;

namespace _1._Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            Message messages = new Message();
            int count = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            for (int i = 1; i <= count; i++)
            {
                Console.WriteLine($"{messages.phrase[rnd.Next(messages.phrase.Length -1)]}"+
                                  $" {messages.eventPhrase[rnd.Next(messages.eventPhrase.Length - 1)]}"+
                                  $" {messages.author[rnd.Next(messages.author.Length - 1)]} - "+
                                  $" {messages.city[rnd.Next(messages.city.Length - 1)]}.");
            }
        }
    }
}
class Message
{  
    public string[] phrase { get; set; } = {"Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product."};
    public string[] eventPhrase { get; set; } = {"Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"};
    public string[] author { get; set; } = {"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"};
    public string[] city { get; set; } = {"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"};
}

