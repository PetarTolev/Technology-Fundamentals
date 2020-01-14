namespace SoftUni_Exam_Results
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            var examResult = new List<Details>();
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "exam finished")
                {
                    break;
                }

                string[] splitedInput = input.Split(" ");
                string username = splitedInput[0];
                string language = splitedInput[1];
                int points = int.Parse(splitedInput[2]);

                Details detail = new Details
                {
                    Username = username,
                    Language = language,
                    Points = points
                };

                if ()
                {
                    
                }
                else
                {
                    detail = new Details
                    {
                        Username = username,
                        Language = language,
                        Points = points
                    };

                    examResult.Add(detail);
                }

            }
        }
    }

    class Details
    {
        public string Username { get; set; }

        public string Language { get; set; }

        public int Points { get; set; }
    }
}
