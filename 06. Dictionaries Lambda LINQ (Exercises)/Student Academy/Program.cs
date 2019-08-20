namespace Student_Academy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, double> studentsAndGrade = new Dictionary<string, double>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (studentsAndGrade.ContainsKey(name))
                {
                    double oldGrade = studentsAndGrade[name];
                    double newGrade = (oldGrade + grade) / 2;
                    studentsAndGrade[name] = newGrade;
                }
                else
                {
                    studentsAndGrade.Add(name, grade);
                }
            }

            foreach (var obj in studentsAndGrade.OrderByDescending(x => x.Value))
            {
                if (obj.Value >= 4.5)
                {
                    Console.WriteLine($"{obj.Key} -> {obj.Value:F2}");
                }
            }
        }
    }
}
