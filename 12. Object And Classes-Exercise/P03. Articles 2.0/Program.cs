using System;
using System.Collections.Generic;
using System.Linq;

namespace P03._Articles_2._0
{
    internal class Program
    {
        class Article
        {
            public Article(string title, string content, string author)
            {
                this.Title = title;
                this.Content = content;
                this.Author = author;
            }
            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }

            public override  string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }

        }

        static void Main(string[] args)
        {
            int numberOfArticles=int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();
            for (int i = 1; i <= numberOfArticles; i++)
            {
                string[] input = Console.ReadLine().Split(", ").ToArray();
                string title=input[0];  
                string content=input[1];    
                string author=input[2];
                Article article = new Article(title, content, author);
                articles.Add(article);  

            }
            string command=Console.ReadLine();
           
            Console.WriteLine(string.Join(Environment.NewLine,articles));

        }
    }
       
    
}
