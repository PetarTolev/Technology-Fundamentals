using System;
using System.Collections.Generic;

namespace Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = new Dictionary<string, List<string>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonim = Console.ReadLine();

                
                if (words.ContainsKey(word) == false)
                {
                    words.Add(word,new List<string>());
                }
                words[word].Add(synonim);
            }

            foreach (var word in words)
            {
                Console.WriteLine($"{word.Key} - {string.Join(", ", word.Value)}");
            }
        }
    }
}
