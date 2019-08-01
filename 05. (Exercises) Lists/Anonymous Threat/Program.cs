using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace Anonymous_Threat
{
    class Program
    {

        public static List<string> input = new List<string>();

        static void Main(string[] args)
        {
            input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command = Console.ReadLine();

            while (command != "3:1")
            {
                List<string> splitCommand = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                if (splitCommand[0] == "divide")
                {
                    DivideElemetnsInList(splitCommand);
                }

                else if (splitCommand[0] == "merge")
                {
                    MergeElementsInList(splitCommand);
                }

                
                    
                    
                    
                command = Console.ReadLine();
            }
        }

        private static void DivideElemetnsInList(List<string> splitCommand)
        {
            int index = int.Parse(splitCommand[1]);
            int parts = int.Parse(splitCommand[2]);

            if (index < 0)
            {
                index = 0;
            }
            else if (index > input.Count - 1)
            {
                index = input.Count - 1;
            }


        }

        private static void MergeElementsInList(List<string> splitCommand)
        {
            int startIndex = int.Parse(splitCommand[1]);
            int endIndex = int.Parse(splitCommand[2]);

            if (startIndex < 0)
            {
                startIndex = 0;
            }
            else if (startIndex > input.Count - 1)
            {
                startIndex = 0;
            }

            if (endIndex > input.Count - 1)
            {
                endIndex = input.Count;
            }


            string ad = "";
            for (int i = startIndex; i < endIndex - 1; i++)
            {
                ad += input[i];
            }

            input.RemoveRange(startIndex, endIndex);

            input.Insert(startIndex, ad);
        }
    }
}
