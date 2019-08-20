namespace ForceBook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> forceBook = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Lumpawaroo")
                {
                    break;
                }

                if (input.Contains(" | "))
                {
                    string[] splitedInput = input.Split(" | ");
                    string forceSide = splitedInput[0];
                    string forceUser = splitedInput[1];

                    if (!forceBook.ContainsKey(forceSide))
                    {
                        forceBook[forceSide] = new List<string>();
                        if (!forceBook.Values.Any(x => x.Contains(forceUser)))
                        {
                            forceBook[forceSide].Add(forceUser);
                        }
                    }
                    else if (!forceBook.Values.Any(x => x.Contains(forceUser)))
                    {
                        forceBook[forceSide].Add(forceUser);
                    }
                }
                else
                {
                    {
                        string[] inputLine = input.Split(" -> ");
                        string forceUser = inputLine[0];
                        string forceSide = inputLine[1];
                        if (!forceBook.ContainsKey(forceSide))
                        {
                            forceBook[forceSide] = new List<string>();
                            if (!forceBook.Values.Any(x => x.Contains(forceUser)))
                            {
                                forceBook[forceSide].Add(forceUser);
                                Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                            }
                            else
                            {
                                foreach (var userSide in forceBook)
                                {
                                    if (userSide.Value.Contains(forceUser))
                                    {
                                        userSide.Value.Remove(forceUser);
                                        forceBook[forceSide].Add(forceUser);
                                        Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                                        break;
                                    }
                                }
                            }
                        }
                        else if (!forceBook.Values.Any(x => x.Contains(forceUser)))
                        {
                            forceBook[forceSide].Add(forceUser);
                            Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                        }
                        else
                        {
                            foreach (var userSide in forceBook)
                            {
                                if (userSide.Value.Contains(forceUser))
                                {
                                    userSide.Value.Remove(forceUser);
                                    forceBook[forceSide].Add(forceUser);
                                    Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                                    break;
                                }
                            }
                        }
                    }
                }
            }

            foreach (var obj in forceBook.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                string forceSide = obj.Key;
                List<string> forceUsers = obj.Value;

                if (forceUsers.Count > 0)
                {
                    Console.WriteLine($"Side: {forceSide}, Members: {forceUsers.Count}");
                }

                foreach (var user in forceUsers.OrderBy(x => x))
                {
                    Console.WriteLine($"! {user}");
                }
            }
        }
    }
}
