using System;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");

            int n = int.Parse(Console.ReadLine());
                
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "Rename")
                {
                    Rename(input, command);
                }
                else if (command[0] == "ChangeAuthor")
                {
                    ChangeAuthor(input, command);
                }
                else if (command[0] == "Edit")
                {
                    Edit(input, command);
                }
            }
            Console.WriteLine($"{input[0]} - {input[1]}: {input[2]}");
        }

        private static void Rename(string[] str, string[] command)
        {
            str[0] = command[1];
        }

        private static void ChangeAuthor(string[] str, string[] command)
        {
            str[2] = command[1];
        }

        private static void Edit(string[] str, string[] command)
        {
            str[1] = command[1];
        }
    }

    class Article
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }
    }
}
