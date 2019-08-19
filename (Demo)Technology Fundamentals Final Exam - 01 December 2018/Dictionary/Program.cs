namespace Dictionary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var wordsAndDescriptionsForResult = new Dictionary<string, List<string>>();

            string[] wordsAndDescriptionsInput = Console.ReadLine().Split(" | ");
            string[] secondInput = Console.ReadLine().Split(" | ");
            string command = Console.ReadLine();

            for (int i = 0; i < wordsAndDescriptionsInput.Length; i++)
            {
                string[] splitedInput = wordsAndDescriptionsInput[i].Split(": ");
                string word = splitedInput[0];
                string description = splitedInput[1];

                if (wordsAndDescriptionsForResult.ContainsKey(word))
                {
                    wordsAndDescriptionsForResult[word].Add(description);
                }
                else
                {
                    List<string> descriptionList = new List<string>{description};
                    wordsAndDescriptionsForResult.Add(word, descriptionList);
                }
            }

            if (command == "End")
            {
                for (int i = 0; i < secondInput.Length; i++)
                {
                    string wordForPrinting = secondInput[i];
                    if (wordsAndDescriptionsForResult.ContainsKey(wordForPrinting))
                    {
                        Console.WriteLine(wordForPrinting);
                        foreach (var desc in wordsAndDescriptionsForResult[wordForPrinting].OrderByDescending(x => x.Length))
                        {
                            Console.WriteLine(" -" + desc);
                        }
                    }
                }
            }
            else if (command == "List")
            {
                foreach (var obj in wordsAndDescriptionsForResult.OrderBy(x => x.Key))
                {
                    Console.Write(obj.Key + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
