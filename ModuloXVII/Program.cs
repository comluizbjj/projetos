using ModuloXVII.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace ModuloXVII
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            Console.Write("Enter salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Email of people whose salary is more than " + baseSalary.ToString("F2", CultureInfo.InvariantCulture) + ":");

            List<Employee> dados = new List<Employee>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    string email = fields[1];
                    double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);

                    dados.Add(new Employee (name, email, salary));
                }
            }

            var emails = dados.Where(p => p.Salary > baseSalary).OrderBy(p => p.Email).Select(p => p.Email);

            foreach ( string email in emails)
            {
                Console.WriteLine(email);
            }
            var salaryM = dados.Where(p => p.Name[0] == 'M').Sum(p => p.Salary);
            Console.WriteLine("Sum of salary of people whose name starts with 'M': " + salaryM.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
