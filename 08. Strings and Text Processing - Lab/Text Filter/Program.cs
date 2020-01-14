using System;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;

namespace Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            foreach (var w in bannedWords)
            {
                if (text.Contains(w))
                {
                    int length = w.Length;

                    string newWord = new string('*', length);

                    text = text.Replace(w, newWord);
                }
            }
            Console.WriteLine(text);
        }
    }
}
