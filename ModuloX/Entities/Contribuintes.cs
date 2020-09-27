using System;
using System.Collections.Generic;
using System.Text;

namespace ModuloX.Entities
{
    abstract class Contribuintes
    {
        public string Nome { get; set; }
        public double Renda { get; set; }

        public Contribuintes(string nome, double renda)
        {
            Nome = nome;
            Renda = renda;
        }

        public abstract double CalcImposto();
    }
}
