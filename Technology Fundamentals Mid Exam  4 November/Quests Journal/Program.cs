using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace Quests_Journal
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command = Console.ReadLine();

            while (command != "Retire!")
            {
                string[] splitedCommand = command.Split(" - ");

                string com = splitedCommand[0];
                string quest = splitedCommand[1];

                if (com == "Start")
                {
                    if (!input.Contains(quest))
                    {
                        input.Add(quest);
                    }
                }
                else if (com == "Complete")
                {
                    if (input.Contains(quest))
                    {
                        input.Remove(quest);
                    }
                }
                else if (com == "Side Quest")
                {
                    string[] qsq = quest.Split(':');

                    string q = qsq[0];
                    string sq = qsq[1];

                    if (input.Contains(q))
                    {
                        if (!input.Contains(sq))
                        {
                            int index = input.IndexOf(q);
                            input.Insert(index + 1, sq);
                        }
                    }
                }
                else if (com == "Renew")
                {
                    int oldIndex = input.IndexOf(quest);

                    if (input.Contains(quest))
                    {
                        input.Add(quest);
                        input.RemoveAt(oldIndex);
                    }
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", input));
        }
    }
}
