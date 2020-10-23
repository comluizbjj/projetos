using ModuloXV.Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace ModuloXV
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            // - - -   E X E C I C I O   D E  C O N J U N T O S   E   H A S H S E T 
            /*
            HashSet<Students> set = new HashSet<Students>();

            String[] course = new string[3];
            course[0] = "A";
            course[1] = "B";
            course[2] = "C";

            for(int cont=0;cont < course.Length;cont++)
            {
                Console.Write("How many students for course " + course[cont] + "? ");
                int qtdStudents = int.Parse(Console.ReadLine());

                for (int cont2 = 0; cont2 < qtdStudents; cont2++)
                {
                    int matricula = int.Parse(Console.ReadLine());
                    set.Add(new Students { IdStudents = matricula, Course = course[cont]});
                }
            }
            Console.WriteLine("Total students: " + set.Count);
            */

            Dictionary < string, int> voto = new Dictionary<string,int>();
            int acumulaVoto;

            Console.Write("Enter file full path: ");
            // deve ser digitado o caminho da pasta do diretorio deste projeto "***ConsoleApp1\ModuloXV\File\in.csv"
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        int qtdVoto = int.Parse(line[1]);

                        if (voto.ContainsKey(name))
                        {
                            acumulaVoto = voto[name];
                            acumulaVoto = qtdVoto + acumulaVoto;
                            voto[name] = acumulaVoto;
                        }
                        else
                        {
                            voto[name] = qtdVoto;
                        }                        
                    }
                    foreach (KeyValuePair<string, int> item in voto)
                    {
                        Console.WriteLine(item.Key + ": " + item.Value);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
