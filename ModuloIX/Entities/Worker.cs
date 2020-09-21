using ModuloIX.Entities.Enums;
using System.Collections.Generic;

namespace ModuloIX.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public double BaseSalary { get; set; }
        public WorkerLevel Level { get; set; }
        public Departament Departament { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();


        public Worker()
        {

        }

        public Worker(string name, double baseSalary, WorkerLevel level, Departament departament)
        {
            Name = name;
            BaseSalary = baseSalary;
            Level = level;
            Departament = departament;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }
        public void RemContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }
        public double Income(int month, int year)
        {

            double sum = BaseSalary;

            foreach(HourContract contract in Contracts)
            {
                if ( contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum = sum + contract.TotalValue();
                }
            }
            
            return sum;
        }
    }

}
