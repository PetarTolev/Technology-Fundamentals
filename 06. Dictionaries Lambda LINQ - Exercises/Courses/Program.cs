using System.Linq;

namespace Courses
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, CourseInformation> coursesInformationDictionary = new Dictionary<string, CourseInformation>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }
                
                string[] splittedInput = input.Split(" : ");
                string courseName = splittedInput[0];
                string studentName = splittedInput[1];

                if (coursesInformationDictionary.ContainsKey(courseName))
                {
                    coursesInformationDictionary[courseName].StudentsNames.Add(studentName);
                    coursesInformationDictionary[courseName].Count++;
                }
                else
                {
                    CourseInformation courseInformation = new CourseInformation()
                    {
                        Count = 1,
                        StudentsNames = new List<string>() { studentName }
                    };

                    coursesInformationDictionary.Add(courseName, courseInformation);
                }
            }

            foreach (var obj in coursesInformationDictionary.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{obj.Key}: {obj.Value.Count}");

                foreach (var name in obj.Value.StudentsNames.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {name}");
                }
            }
        }
    }

    class CourseInformation
    {
        public List<string> StudentsNames { get; set; }

        public int Count { get; set; }
    }
}
