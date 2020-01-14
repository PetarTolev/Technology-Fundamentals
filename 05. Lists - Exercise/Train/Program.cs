using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int capacity = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commandArray = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (commandArray[0] == "Add")
                {
                    input.Add(int.Parse(commandArray[1]));
                }
                else
                {
                    int count = 0;
                    while (input[count] + int.Parse(commandArray[0]) < capacity) 
                    {
                        if (input[count] + int.Parse(commandArray[0]) < capacity)
                        {
                            input[count] = input[count] + int.Parse(commandArray[0]);
                        }
                        else
                        {
                            count++;
                        }
                        count++;
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(' ', input));
        }
    }
}
