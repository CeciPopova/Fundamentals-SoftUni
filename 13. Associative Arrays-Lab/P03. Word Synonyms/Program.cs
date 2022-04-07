using System;
using System.Collections.Generic;

namespace P03._Word_Synonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            Dictionary<string,List<string>> sinonimList = new Dictionary<string,List<string>>();

            for (int i = 0; i < n; i++)
            {
                string word=Console.ReadLine(); 
                string sinonim=Console.ReadLine();

                if (!sinonimList.ContainsKey(word))
                {
                    sinonimList.Add(word, new List<string>());
                    
                }
             sinonimList[word].Add(sinonim);
            }
            foreach (var item in sinonimList)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ",item.Value)}");
            }
        }
    }
}
