using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ModuloIV
{
    class Aluno
    {
        public string Nome;
        public double NotaFinal;
        public double Pontos;

        public double SomarNotas(double Nota1, double Nota2, double Nota3)
        {
            return NotaFinal= Nota1 + Nota2 + Nota3;
        }

        public double ValidarPontos()
        {
            return Pontos = 60.00 - NotaFinal;
        }
        public override string ToString()
        {
            return Pontos.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
