using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Articles_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
                        
            Article article = new Article();

            List<Article> listarticle = new List<Article>();

            for (int i = 0; i < count; i++)
            {
                List<string> commands = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();                              

                listarticle.Add(new Article{

                Title = commands[0],
                Content = commands[1],
                Author = commands[2],
                });
            }            
            foreach (var item in listarticle)
            {
                Console.WriteLine($"{item.Title} - {item.Content}: {item.Author}");
            }
        }
    }

    class Article
    {        
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }                       
    }
}
