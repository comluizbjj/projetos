using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = 0.00;

            /*
                        while (n1 >= 0) {
                            Console.WriteLine("Digite um numero abaixo:");
                            n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                            double raiz = Math.Sqrt(n1);
                            Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                        }
                        Console.WriteLine("Irmãooooo, numero digitado negativo!!!");


                        for (int cont=1; n1>=0.0 && cont <= 3;cont++)
                        {
                            Console.WriteLine("Digite um numero abaixo:");
                            n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                            double raiz = Math.Sqrt(n1);
                            Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                        }
                        Console.WriteLine("Irmãooooo, numero digitado negativo ou vc ja testou mais que 3vezes!!!");

            */
            Funcionario dados1, dados2;

            dados1 = new Funcionario();
            dados2 = new Funcionario();

            
            Console.WriteLine("Dados do primeiro funcionario");
            Console.Write("Nome   : ");
            dados1.Nome = Console.ReadLine();
            Console.Write("Salario: " );
            dados1.Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionario");
            Console.Write("Nome   : ");
            dados2.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            dados2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double SalarioMedio = (dados1.Salario + dados2.Salario) / 2;

            Console.Write("Salário Médio = " + SalarioMedio.ToString("F2",CultureInfo.InvariantCulture));
            






        }
    }
}
