using ModuloX.Entities;
using System;
using System.Globalization;
using System.Collections.Generic;

namespace ModuloX
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            //  - - - >           E x e r c i c i o   d e   H e r a n ç a   e   P o l i f o r f i s m o         < - - - 
            /*
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int qtdEmployee = int.Parse(Console.ReadLine());

            for(int cont = 1;cont <= qtdEmployee; cont++)
            {
                Console.WriteLine($"Product #{cont} data: ");
                Console.Write("Common, used or imported (c/u/i)? ");
                char p = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if ( p == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(customFee, name, price));
                }
                else if( p == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(date, name, price));
                }
                else
                {
                    list.Add(new Product(name,price));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");
            foreach (Product dados in list)
            {
                Console.WriteLine(dados.PriceTag());
            }
            */
            //
            // = = = = = >     E x e r c i c i o    c o m     C l a s s e s     e     M é t o d o s     A b s t r a t o s
            //
            List<Contribuintes> list = new List<Contribuintes>();

            Console.Write("Enter the number of tax payers: ");
            int qtdEmployee = int.Parse(Console.ReadLine());

            for(int cont =1; cont <= qtdEmployee; cont++)
            {
                Console.WriteLine($"Tax payer #{cont} data:" );
                Console.Write("Individual or company (i/c)? ");
                char tpContrib = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double valorRenda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (tpContrib == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double valorSaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new PhysicalPerson(valorSaude, name, valorRenda));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int qtdFunc = int.Parse(Console.ReadLine());
                    list.Add(new LegalPerson(qtdFunc, name, valorRenda));
                }
            }
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");

            double totalTaxas = 0;
            foreach(Contribuintes dados in list)
            {
                Console.WriteLine(dados.Nome+": $ "+dados.CalcImposto().ToString("F2",CultureInfo.InvariantCulture));
                totalTaxas = totalTaxas + dados.CalcImposto();
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ "+totalTaxas.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
