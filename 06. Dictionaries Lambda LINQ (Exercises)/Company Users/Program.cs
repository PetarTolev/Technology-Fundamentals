namespace Company_Users
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string[] splittedInput = input.Split(" -> ");
                string companyName = splittedInput[0];
                string employeeId = splittedInput[1];

                if (companies.ContainsKey(companyName))
                {
                    if (!companies[companyName].Contains(employeeId))
                    {
                        companies[companyName].Add(employeeId);
                    }
                }
                else
                {
                    List<string> employeesIdList = new List<string>() {employeeId};

                    companies.Add(companyName, employeesIdList);
                }
            }
            
            foreach (var company in companies.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{company.Key}");

                foreach (var employee in company.Value)
                {
                    Console.WriteLine($"-- {employee}");
                }
            }
        }
    }
}
