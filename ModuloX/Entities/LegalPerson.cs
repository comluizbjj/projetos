using System;
using System.Collections.Generic;
using System.Text;

namespace ModuloX.Entities
{
    class LegalPerson : Contribuintes
    {
        public int QtdEmployee { get; set; }

        public LegalPerson(int qtdEmployee, string nome, double renda) :base(nome,renda)
        {
            QtdEmployee = qtdEmployee;
        }
        public override double CalcImposto()
        {
                        
            if(QtdEmployee > 10)
            {
                return Renda * 0.14;
            }
            else
            {
                return Renda * 0.16;
            }
        }
    }
}
