using System;
using System.Dynamic;
using System.Globalization;

namespace ModuloIV
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            //-----------------------   E X E R C I C I O   I   --------------------------------
            Retangulo dados = new Retangulo();
    
            Console.WriteLine("Entre a largura e altura do retangulo:");
            dados.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            dados.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double area = dados.Area();
            Console.WriteLine("AREA = " + area.ToString("F2", CultureInfo.InvariantCulture));

            double perimetro = dados.Perimetro();
            Console.WriteLine("PERIMETRO = " + perimetro.ToString("F2", CultureInfo.InvariantCulture));

            double diagonal = dados.Diagonal();
            Console.WriteLine("DIAGONAL = " + diagonal.ToString("F2", CultureInfo.InvariantCulture));
            */

            //-----------------------   E X E R C I C I O   II   -------------------------------
            /*
            Funcionario dados = new Funcionario();

            String Nome;

            Console.Write("Nome: ");
            Nome = Console.ReadLine();
            Console.Write("Salario bruto: ");
            dados.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            dados.ValorImposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            dados.SalarioLiquido();
            Console.WriteLine(" ");

            Console.WriteLine("Funcionario : " + Nome + dados);

             Console.WriteLine(" ");

            Console.Write("Digite a porcentagem para aumentar o salario: ");
            double percent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            dados.AumentarSalario(percent);
            Console.WriteLine(" ");

            Console.WriteLine("Dados atualizados: " + Nome + dados);
            */
            //-----------------------   E X E R C I C I O   III   -------------------------------
            /*
            
            Aluno dados = new Aluno();

            Console.Write("Nome do Aluno: ");
            dados.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno:");
            double Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            dados.SomarNotas(Nota1, Nota2, Nota3);

            Console.Write("NOTA FINAL = " + dados.NotaFinal.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine();

            dados.ValidarPontos();

            if (dados.Pontos < 0.0) {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.Write("FALTARAM " + dados + " PONTOS. ");
            }
            */

            //-----------------------   E X E R C I C I O   IV   -------------------------------

            Console.Write("Qual é a cotação do dólar? ");
            double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double qtdDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double valor = ConversorDeMoeda.Calcular(dolar, qtdDolar);

            Console.WriteLine("Valor a ser pago em reais = " + valor.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
