namespace Song_Encryption
{
    using System;

    class Program
    {
        static void Main(string[] args)
            {
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                string[] splitedInput = input.Split(":");
                string artist = splitedInput[0];
                string song = splitedInput[1];

                if (IsArtisValid(artist) || IsSongValid(song))
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    var charArray = input.ToCharArray();

                    for (int i = 0; i < charArray.Length; i++)
                    {
                        if (charArray[i] == 39 || charArray[i] == 32)
                        {
                            continue;
                        }
                        else if (charArray[i] == 58)
                        {
                            charArray[i] = (char)64;
                            continue;
                        }


                        if (charArray[i] + artist.Length < 122 && charArray[i] + artist.Length > 97)
                        {
                            charArray[i] = (char)(charArray[i] + artist.Length);

                            if (charArray[i] > 122)
                            {
                                int a = 122 - charArray[i];

                                charArray[i] = (char)(97 + a);
                            }
                        }

                        if (charArray[i] + artist.Length < 90 && charArray[i] + artist.Length > 65)
                        {
                            charArray[i] = (char) (charArray[i] + artist.Length);

                            if (charArray[i] > 90)
                            {
                                int a = 90 - charArray[i];

                                charArray[i] = (char) (65 + a);
                            }
                        }



                    }
                    Console.WriteLine($"Successful encryption: {string.Join("", charArray)}");
                }

            }
        }
        
        private static bool IsArtisValid(string artist)
        {
            var charArray = artist.ToCharArray();

            if (charArray[0] < 65 && charArray[0] > 90)
            {
                return true;
            }

            for (int i = 1; i < charArray.Length; i++)
            {
                if (charArray[i] < 97 || charArray[i] > 122)
                {
                    if (charArray[i] == 32 || charArray[i] == 39)
                    {
                        continue;
                    }
                    return true;
                }
            }
            return false;
        }

        private static bool IsSongValid(string song)
        {
            var charArray = song.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] < 65 || charArray[i] > 90 && charArray[i] != 32)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
