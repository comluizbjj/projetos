using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ModuloVI
{
    class Employee
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salary { get; private set; }  

        public Employee(int id, string nome, double salary)
        {
            Id = id;
            Nome = nome;
            Salary = salary;
        }
        public void IncreaseSalary(double percentage)
        {
            Salary = Salary + ((percentage / 100) * Salary);
        }

        public override string ToString()
        {
            return Id + ", " + Nome + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
