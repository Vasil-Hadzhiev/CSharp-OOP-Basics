namespace _06.CompanyRoster
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var company = new Dictionary<string, List<Employee>>();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var employeeTokens = Console.ReadLine().Split();

                var name = employeeTokens[0];
                var salary = double.Parse(employeeTokens[1]);
                var position = employeeTokens[2];
                var department = employeeTokens[3];
                var email = string.Empty;
                var age = 0;

                var employee = new Employee(name, salary);

                if (employeeTokens.Length == 6)
                {
                    email = employeeTokens[4];
                    age = int.Parse(employeeTokens[5]);
                    employee.Email = email;
                    employee.Age = age;
                }
                else if (employeeTokens.Length == 5)
                {
                    var parser = 0;

                    if (int.TryParse(employeeTokens[4], out parser))
                    {
                        age = int.Parse(employeeTokens[4]);
                        employee.Age = age;
                    }
                    else
                    {
                        email = employeeTokens[4];
                        employee.Email = email;
                    }
                }

                if (!company.ContainsKey(department))
                {
                    company[department] = new List<Employee>();
                }

                company[department].Add(employee);
            }

            var highestPaidDepartment = company
                 .OrderByDescending(e => e.Value.Sum(d => d.Salary))
                 .First()
                 .Key;

            Console.WriteLine($"Highest Average Salary: {highestPaidDepartment}");

            foreach (var employee in company[highestPaidDepartment]
                .OrderByDescending(e => e.Salary)
                .ToList())
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:f2} {employee.Email} {employee.Age}");
            }
        }
    }
}