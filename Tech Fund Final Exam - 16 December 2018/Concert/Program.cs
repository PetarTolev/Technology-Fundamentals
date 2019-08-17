namespace Concert
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            var bandList = new Dictionary<string, List<string>>();
            Dictionary<string, int> bandsTime = new Dictionary<string, int>(); 

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "start of concert")
                {
                    break;
                }

                string[] splitedInput = input.Split("; ");
                string command = splitedInput[0];
                string bandName = splitedInput[1];

                if (command == "Add")
                {
                    List<string> members = splitedInput[2].Split(", ").ToList();

                    if (bandList.ContainsKey(bandName))
                    {
                        foreach (var band in bandList)
                        {
                            if (band.Key == bandName)
                            {
                                for (int i = 0; i < members.Count; i++)
                                {
                                    if (!band.Value.Contains(members[i]))
                                    {
                                        band.Value.Add(members[i]);
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        bandList.Add(bandName, members);
                    }
                }
                else if (command == "Play")
                {
                    int bandTime = int.Parse(splitedInput[2]);

                    if (!bandsTime.ContainsKey(bandName))
                    {
                        bandsTime.Add(bandName, bandTime);
                    }
                    else
                    {
                        bandsTime[bandName] += bandTime;
                    }
                }
            }

            string bandForPrint = Console.ReadLine();
            int totalTime = bandsTime.Values.Sum();

            Console.WriteLine($"Total time: {totalTime}");

            foreach (var objKeyValuePair in bandsTime.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{objKeyValuePair.Key} -> {objKeyValuePair.Value}");
            }

            if (bandList.ContainsKey(bandForPrint))
            {
                var members = bandList[bandForPrint];
                
                Console.WriteLine(bandForPrint);

                foreach (var member in members)
                {
                    Console.WriteLine($"=> {member}");
                }
            }
        }
    }
}
