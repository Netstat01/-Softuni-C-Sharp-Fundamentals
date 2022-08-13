using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strArticle = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            int count = int.Parse(Console.ReadLine());
            Article article = new Article(strArticle);

            for (int i = 0; i < count; i++)
            {
                List<string> commands = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries).ToList();

                switch (commands[0])
                {
                    case "Edit":
                        article.Edit(commands[1]);
                        break;

                    case "ChangeAuthor":
                        article.ChangeAuthor(commands[1]);
                        break;

                    case "Rename":
                        article.Rename(commands[1]);
                        break;

                }
            }
            Console.WriteLine(article);
        }
    }

    class Article
    {
        public Article(string[] strArticle)
        {
            this.strArticle = strArticle;
            this.Title = this.strArticle[0];
            this.Content = this.strArticle[1];
            this.Author = this.strArticle[2];


        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public string toString { get; set; }
        public string[] strArticle { get; set; }


        public void Edit(string command)
        {
            strArticle[1] = command;
        }
        public void ChangeAuthor(string command)
        {
            strArticle[2] = command;
        }

        public void Rename(string command)
        {
            strArticle[0] = command;
        }

        public override string ToString() => $"{strArticle[0]} - {strArticle[1]}: {strArticle[2]}";
    }
}
