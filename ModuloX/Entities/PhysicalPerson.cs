using System;
using System.Collections.Generic;
using System.Text;

namespace ModuloX.Entities
{
    class PhysicalPerson : Contribuintes
    {
        public double AmountHealth { get; set; }

        public PhysicalPerson(double amountHealth, string nome, double renda) : base(nome, renda)
        {
            AmountHealth = amountHealth;
        }

        public override double CalcImposto()
        {
            double impostoRenda;
            double descSaude = 0.0;

            if (Renda <= 20000.00)
            {
                impostoRenda = Renda * 0.15 ;
            }
            else
            {
                impostoRenda = Renda * 0.25;
            }
            if(AmountHealth > 0)
            {
                descSaude = AmountHealth * 0.5;
            }
            return impostoRenda - descSaude;
        }


    }
}
