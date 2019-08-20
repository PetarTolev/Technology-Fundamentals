namespace A_Miner_Task
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            while (true)
            {
                string resource = Console.ReadLine();

                if (resource == "stop")
                {
                    break;
                }

                int quantity = int.Parse(Console.ReadLine());

                if (result.ContainsKey(resource))
                {
                    result[resource] += quantity;
                }
                else
                {
                    result.Add(resource, quantity);
                }
            }

            foreach (var obj in result)
            {
                Console.WriteLine($"{obj.Key} -> {obj.Value}");
            }
        }
    }
}
