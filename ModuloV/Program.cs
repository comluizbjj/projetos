using System;
using System.Globalization;

namespace ModuloV
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaBancaria dados;

            Console.Write("Entre com o numero da conta: ");
            int conta = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá deposito inicial (s/n): ");
            string flagDep = Console.ReadLine();

            ContaBancaria flag = new ContaBancaria();

            flag.FlagDep = flagDep;

            double depInicial = 0.00;
            
            if (flagDep == "s")
            {
                Console.Write("Entre com o valor de deposito inicial: ");
                depInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                dados = new ContaBancaria(conta, titular, depInicial);
            }else
            {
                dados = new ContaBancaria(conta, titular);
            }
           
            
                        
            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(dados);
            Console.WriteLine();

            Console.Write("Entre com o valor para deposito: ");
            double valorDep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            dados.AddDeposito(valorDep);            
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(dados);
            Console.WriteLine();

            Console.Write("Entre com o valor para saque: ");
            double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            dados.Saque(valorSaque);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(dados);
            Console.WriteLine();

            Console.WriteLine("Dados da conta atualizados:"+dados.FlagDep);



        }
    }
}
