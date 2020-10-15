using ModuloXV.Entities;
using System;
using System.Collections.Generic;

namespace ModuloXV
{
    class Program
    {
        static void Main(string[] args)
        {

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
        }
    }
}
