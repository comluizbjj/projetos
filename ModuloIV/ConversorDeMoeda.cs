using System;
using System.Collections.Generic;
using System.Text;

namespace ModuloIV
{
    class ConversorDeMoeda
    {
        public static double ICMS = 1.06;

        public static double Calcular(double dolar, double quant)
        {
            return (dolar * quant) * ICMS;
        }
    }

}
