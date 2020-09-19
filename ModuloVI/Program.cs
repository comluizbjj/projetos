using System;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;

namespace ModuloVI
{
    class Program
    {
        static void Main(string[] args)
        {
            //-----------------------   E X E R C I C I O   I   -------------------------------//
            /*
            Console.Write("Quantos quartos serão alugados? ");
            int qtdQuartos = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Quartos[] lista = new Quartos[10];

            for(int cont= 1; cont <= qtdQuartos; cont++)
            {
                
                Console.WriteLine("Aluguel #"+cont.ToString()+":");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                Console.WriteLine();

                lista[quarto] = new Quartos (quarto,nome, email);
            }
                        
            Console.WriteLine("Quartos Ocupados:");
            for (int cont= 0; cont<10; cont++)
            {
                if(lista[cont] != null)
                {
                    Console.WriteLine(lista[cont]);
                }
            }
            */
            //
            //-----------------------   E X E R C I C I O   II  - L I S T A S -----------------------------//
            /*
            Console.Write("How many employees will be registered? ");
            int qtdFuncionario = int.Parse(Console.ReadLine());

            List<Employee> func  = new List<Employee>();
       
            for (int cont = 1; cont <= qtdFuncionario; cont++)
            {
                Console.WriteLine("Employee # "+ cont.ToString() + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = (Console.ReadLine());
                Console.Write("Salary: ");
                double salary = (double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture));

                func.Add(new Employee (id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase : " );
            int employeePlus = int.Parse(Console.ReadLine());

            Employee s1 = func.Find(x => x.Id == employeePlus);
            
            if(s1 != null){  
                Console.Write("Enter the percentage: ");
                double percPlus = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                s1.IncreaseSalary(percPlus);
                Console.WriteLine();                
            }
            else
            {
                Console.WriteLine("This id does not exist.");
                Console.WriteLine();
            }            

            Console.WriteLine("Updated list of employees:");

            foreach (Employee obj in func)
            {
                Console.WriteLine(obj);
            }
            */
            //
            //-----------------------   E X E R C I C I O   III  -  M A T R I Z  -----------------------------//
            //

            string[] tamanho = Console.ReadLine().Split(' ');
                        
            int linhas = int.Parse(tamanho[0]);
            int colunas = int.Parse(tamanho[1]);

            int[,] matriz = new int[linhas, colunas];

            for(int contLinha = 0; contLinha < linhas; contLinha++)
            {
                string[] dadosTabela = Console.ReadLine().Split(' ');
                for(int contColuna = 0; contColuna < colunas; contColuna++)
                {
                    matriz[contLinha, contColuna] = int.Parse(dadosTabela[contColuna]);
                }
            }
            int valorRef = int.Parse(Console.ReadLine());

            //pesquisar o valor de referencia na matriz
            for (int contLinha = 0; contLinha < linhas; contLinha++)
            {
                for (int contColuna = 0; contColuna < colunas; contColuna++)
                {
                    if (valorRef == matriz[contLinha, contColuna])
                    {
                        int auxLeft = contColuna - 1;
                        int auxRight = contColuna + 1;
                        int auxUp = contLinha - 1;
                        int auxDown = contLinha + 1;

                        Console.Write("Position " + contLinha.ToString()+","+contColuna.ToString()+":");
                        Console.WriteLine();
                        if (auxLeft >= 0)
                        {
                            int left = matriz[contLinha, auxLeft];
                            Console.Write("Left: " + left.ToString());
                            Console.WriteLine();

                        }
                        if(auxRight < colunas)
                        {
                            int right = matriz[contLinha, auxRight];
                            Console.Write("Right: " + right.ToString());
                            Console.WriteLine();
                        }
                        if (auxUp >= 0)
                        {
                            int up = matriz[auxUp, contColuna];
                            Console.Write("Up: " + up.ToString());
                            Console.WriteLine();
                        }
                        if (auxDown < linhas)
                        {
                            int down = matriz[auxDown, contColuna];
                            Console.Write("Down: " + down.ToString());
                            Console.WriteLine();
                        }
                    }

                }
            }
        }
    }
}
