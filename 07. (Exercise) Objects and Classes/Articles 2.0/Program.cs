using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace Articles_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Articles> articles = new List<Articles>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(", ");

                string title = input[0];
                string content = input[1];
                string author = input[2];

                Articles article = new Articles()
                {
                    Title = title,
                    Content = content,
                    Autohor = author
                };

                articles.Add(article);
            }

            string criteria = Console.ReadLine();

            if (criteria == "title")
            {
                articles = articles.OrderBy(t => t.Title).ToList();

                PrintResult(articles);
            }
            else if (criteria == "content")
            {
                articles = articles.OrderBy(t => t.Content).ToList();

                PrintResult(articles);
            }
            else if (criteria == "author")
            {
                articles = articles.OrderBy(t => t.Autohor).ToList();

                PrintResult(articles);
            }
        }

        private static void PrintResult(List<Articles> articles)
        {
            foreach (var article in articles)
            {
                string title = article.Title;
                string content = article.Content;
                string author = article.Autohor;

                Console.WriteLine($"{title} - {content}: {author}");
            }
        }
    }

    class Articles
    {
        public string Title { get; set; }

        public string Content { get; set; } 

        public string Autohor { get; set; }
    }
}
