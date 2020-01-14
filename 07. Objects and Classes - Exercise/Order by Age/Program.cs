using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] splittedInput = input.Split(' ');

                string name = splittedInput[0];
                string id = splittedInput[1];
                int age = int.Parse(splittedInput[2]);

                Person person = new Person()
                {
                    Name = name,
                    ID = id,
                    Age = age
                };

                people.Add(person);

                input = Console.ReadLine();
            }

            people = people.OrderBy(a => a.Age).ToList();

            foreach (var person in people)
            {
                string name = person.Name;
                string id = person.ID;
                int age = person.Age;

                Console.WriteLine($"{name} with ID: {id} is {age} yearse old.");
            }
        }
    }

    class Person
    {
        public string ID { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }
    }
}
