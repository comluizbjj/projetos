using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ModuloV
{   
    class ContaBancaria
    {
        private int _conta;
        private string _nome;
        public double Valor { get; private set; }
        private string _flagDep = "n";

        private double _taxaSaque = 5.00;

        public ContaBancaria() { }

        public ContaBancaria(int conta, string nome)
        {
            _conta = conta;
            _nome = nome;
        }
        public  ContaBancaria (int conta, string nome, double valor):this(conta,nome)
        {
            this.Valor = valor;
        }
       
        public string FlagDep
        {
            get { return _flagDep; }
            set
            {
                if (value !=null && value != "s")
                {
                    _flagDep = value;
                }
            }
        }

        public void AddDeposito(double valor)
        {
            Valor = Valor + valor;
        }

        public void Saque(double valor)
        {
            Valor = Valor - _taxaSaque;
            Valor = Valor - valor;
        }
                
        public override string ToString()
        {
            return "Conta "+_conta.ToString()+ ", Titular: "+_nome+", Saldo: $ "+ Valor.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
