namespace Legendary_Farming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Dictionary<string, int> materials = new Dictionary<string, int>();

            materials.Add("shards", 0);
            materials.Add("fragments", 0);
            materials.Add("motes", 0);

            Dictionary<string, int> junks = new Dictionary<string, int>();

            while (true)
            {
                var input = Console.ReadLine().Split(' ');

                for (int i = 0; i < input.Length; i += 2)
                {
                    int quantity = int.Parse(input[i]);
                    string material = input[i + 1].ToLower();

                    if (material == "shards" || material == "fragments" || material == "motes")
                    {
                        materials[material] += quantity;
                    }
                    else
                    {
                        if (junks.ContainsKey(material))
                        {
                            junks[material] += quantity;
                        }
                        else
                        {
                            junks.Add(material, quantity);
                        }
                    }

                    if (material == "shards" || material == "fragments" || material == "motes")
                    {
                        if (materials[material] >= 250)
                        {
                            PrintOutputMaterials(materials, material);
                            PrintOutputJunks(junks);
                            return;
                        }
                    }
                }
            }
        }

        private static void PrintOutputJunks(Dictionary<string, int> junks)
        {
            foreach (var junk in junks.OrderBy(j => j.Key))
            {
                Console.WriteLine($"{junk.Key}: {junk.Value}");
            }
        }

        private static void PrintOutputMaterials(Dictionary<string, int> materials, string material)
        {
            materials[material] -= 250;

            if (material == "shards")
            {
                Console.WriteLine("Shadowmourne obtained!");
            }
            else if (material == "fragments")
            {
                Console.WriteLine("Valanyr obtained!");
            }
            else if (material == "motes")
            {
                Console.WriteLine("Dragonwrath obtained!");
            }

            foreach (var mat in materials.OrderByDescending(m => m.Value).ThenBy(m => m.Key))
            {
                Console.WriteLine($"{mat.Key}: {mat.Value}");
            }
        }
    }
}
