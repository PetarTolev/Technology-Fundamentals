using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split(' ');

                string firstName = tokens[0];
                string lastName = tokens[1];
                int age = int.Parse(tokens[2]);
                string hometown = tokens[3];

                Student student = new Student()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age,
                    Hometown = hometown
                };

                students.Add(student);
                input = Console.ReadLine();
            }

            string town = Console.ReadLine();

            foreach (var student in students)
            {
                if (student.Hometown == town)
                {
                    string firstName = student.FirstName;
                    string lastName = student.LastName;
                    int age = student.Age;

                    Console.WriteLine($"{firstName} {lastName} is {age} years old.");
                }
            }
        }
    }

    class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string Hometown { get; set; }
    }
}
