using System;
using System.Globalization;
using ModuloXIV___Interfaces.Entities;
using ModuloXIV___Interfaces.Services;

namespace ModuloXIV___Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int contractNumber = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime contractDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());

            Contract dados = new Contract(contractNumber, contractDate, contractValue);

            ContractServices contractServices = new ContractServices(new ValueJuros());
            contractServices.ProcessContract(dados, months);

            Console.WriteLine("Installments:");
            foreach (Installment installment in dados.Installments)
            {
                Console.WriteLine(installment);

            }
        }
    }
}