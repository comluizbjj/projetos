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

            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int qtdEmployee = int.Parse(Console.ReadLine());

            for(int cont = 1;cont <= qtdEmployee; cont++)
            {
                Console.WriteLine($"Product #{cont} data:");
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
        }
    }
}
