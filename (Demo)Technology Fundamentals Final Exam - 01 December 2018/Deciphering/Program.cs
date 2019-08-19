namespace Deciphering
{
    using System;

    class Program
    {
        static void Main()
        {
            string stringForDecipher = Console.ReadLine();

            string[] substring = Console.ReadLine().Split(" ");
            string firstString = substring[0];
            string secondString = substring[1];

            string newString = "";
            foreach (var c in stringForDecipher)
            {
                if (c >= 100 && c <= 125 || c == 35)
                {
                    char newChar = (char)(c - 3);
                    newString += newChar;
                }
                else
                {
                    Console.WriteLine("This is not the book you are looking for.");
                    return;
                }
            }

            
            Console.WriteLine(newString.Replace(firstString, secondString));
        }
    }
}
