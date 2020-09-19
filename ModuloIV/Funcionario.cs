 using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ModuloIV
{
    class Funcionario
    {
        public double Salario;
        public double ValorImposto;
        

        public double SalarioLiquido()
        {
            return Salario - ValorImposto;
        }

        public void AumentarSalario(double PercentualAumento)
        {
            Salario = Salario + (Salario * PercentualAumento / 100.0); 
        }

        public override string ToString()
        {
            return ", $ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
