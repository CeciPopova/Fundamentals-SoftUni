using System;
using System.Collections.Generic;
using System.Linq;

namespace P02._Articles
{
    internal class Program
    {
        class Article
        {
            public Article(string title, string content,string author)
            {
                this.Title = title;
                this.Content = content; 
                this.Author = author;   
            }
            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }

            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }
        }
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ").ToArray();
            int n = int.Parse(Console.ReadLine());
            string title=input[0];
            string content=input[1];  
            string author=input[2];
           Article article= new Article(title, content, author);
            List<Article> articles = new List<Article>();

            for (int i = 1; i <= n; i++)
            {
                string command = Console.ReadLine();
                string[] arr = command.Split(": ");

                string action = arr[0]; 

                if (action =="Edit")
                {
                    string newContend = arr[1]; 
                   article.Content=newContend;  
                }
                else if (action =="ChangeAuthor")
                {
                    string newAuthor=arr[1];
                    article.Author=newAuthor;   
                }
                else if (action=="Rename")
                {
                    string newTitle=arr[1]; 
                    article.Title=newTitle; 

                }
                articles.Add(article);
                
            }
            Console.WriteLine(article.ToString());
        }
    }
}
