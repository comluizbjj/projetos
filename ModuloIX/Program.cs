using ModuloIX.Entities;
using ModuloIX.Entities.Enums;
using System;
using System.Globalization;

namespace ModuloIX
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercicio praticando - - - >    E N U M E R A Ç Õ E S 
            /*
            Departament dados = new Departament();

            Console.Write("Enter department's name: ");
            dados.Name = Console.ReadLine();

            Worker dadosFunc = new Worker();

            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            dadosFunc.Name = Console.ReadLine();
            Console.Write("Level (Junior/Midlevel/Senior): ");
            dadosFunc.Level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            dadosFunc.BaseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);     

            Console.Write("How many contracts to this worker? ");
            int qtdFunc = int.Parse(Console.ReadLine());

            for(int cont = 1; cont <= qtdFunc; cont++)
            {
                Console.WriteLine("Enter #" + cont + " contract data:");

                Console.Write("Date (DD/MM/YYYY): ");
                
                DateTime dateContr = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valorContr = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hourContr = int.Parse(Console.ReadLine());
                HourContract dadosContrato = new HourContract(dateContr, valorContr, hourContr);
                dadosFunc.AddContract(dadosContrato);
            }
            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthYaer = Console.ReadLine();

            int month = int.Parse(monthYaer.Substring(0, 2));
            int year = int.Parse(monthYaer.Substring(3, 4));
            double salaryPlus = dadosFunc.Income(month, year);

            
            Console.Write("Name: " + dadosFunc.Name);
            Console.WriteLine("Departament: " + dados.Name);
            Console.Write("Income for " + monthYaer + ": " + salaryPlus.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine();
            */
            //
            // Exercicio  D E S A F I O:    E n u m e r a ç õ e s    ++    C o m p o s i ç ã o     ++     S t r i n g   B u i l d e r
            //

            Client dadosClient = new Client();

            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            dadosClient.Name = Console.ReadLine();
            Console.Write("Email: ");
            dadosClient.Email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            dadosClient.BirthDate = DateTime.Parse(Console.ReadLine());

            Order dadosOrder = new Order();
            Console.WriteLine("Enter order data:");
            dadosOrder.Moment = DateTime.Now;
            Console.Write("Status: ");
            dadosOrder.Status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Console.Write("How many items to this order? ");
            int qtdItems = int.Parse(Console.ReadLine());            
           
            for(int cont=1; cont <= qtdItems; cont++)
            {
                Console.WriteLine("Enter #"+cont+" item data:");
                Console.Write("Product name: ");
                string nameProd = Console.ReadLine();
                Console.Write("Product price: ");
                double valorProd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int qtdProd = int.Parse(Console.ReadLine());

                Product dadosProd = new Product(nameProd, valorProd);
                OrderItem orderItems = new OrderItem(qtdProd,valorProd,dadosProd);

                dadosOrder.AddItem(orderItems);
            }
            Console.WriteLine();

            Console.WriteLine("ORDER SUMMARY: ");
            Console.WriteLine("Order moment: " + dadosOrder.Moment.ToString("dd/MM/yyyy hh:mm:ss"));
            Console.WriteLine("Order status: " + dadosOrder.Status);
            Console.Write("Client: " +dadosClient.Name+ " ("+dadosClient.BirthDate.ToString("dd/MM/yyyy")+ ") - "+dadosClient.Email);
            Console.WriteLine();
            Console.WriteLine("Order Items: ");
            Console.Write(dadosOrder);
            double total = dadosOrder.Total();
            Console.WriteLine("Total Price: $" + total.ToString("F2"),CultureInfo.InvariantCulture);
        }
    }
}
