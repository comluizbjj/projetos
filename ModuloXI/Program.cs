using ModuloXI.Entities;
using ModuloXI.Entities.Exception;
using System;
using System.Globalization;

namespace ModuloXI
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Account dados = new Account();
                
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                dados.Number = int.Parse(Console.ReadLine());
                Console.Write("Holder: " );
                dados.Holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                dados.Deposit(balance);
                Console.Write("Withdraw limit: ");
                dados.WithdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                dados.Withdraw(limit);

                Console.WriteLine("New balance: " + dados.Balance.ToString("F2", CultureInfo.InvariantCulture));

            }
            catch(DomainException e)
            {
                Console.WriteLine("Withdraw error: "+ e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine("Error in format: " + e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Unexpected Error: "+ e.Message);
            }                
        }
    }
}
