using ModuloXIII.Entities;
using System;
using System.Globalization;
using System.IO;
using System.Linq;

namespace ModuloXIII
{
    class Program
    {
        static void Main(string[] args)
        {
            string path  = @"C:\Users\Luiz Henrique\source\repos\ConsoleApp1\ModuloXIII\Arquivo\dados.csv";
            string path2 = @"C:\Users\Luiz Henrique\source\repos\ConsoleApp1\ModuloXIII\Arquivo\Out\summary.csv";

            try
            {
                
                string[] lines = File.ReadAllLines(path);
                using (StreamWriter sw = File.CreateText(path2))
                    
                {
                    foreach (String line in lines)
                    {
                        string[] fields = line.Split(',');

                        Produtos dados = new Produtos();

                        dados.NameProduto = fields[0];
                        dados.Valor = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        dados.Qtd = int.Parse(fields[2]);

                        double total = dados.CalcEstoque();

                        string dadosImpressos = dados.NameProduto+";"+ total.ToString("F2", CultureInfo.InvariantCulture);
                        sw.WriteLine(dadosImpressos);

                    }
                }
                
            }
            catch (IOException erro)
            {
                Console.WriteLine("UM ERRO OCORRIDO: ");
                Console.WriteLine(erro.Message);
            }
        }
    }
}
