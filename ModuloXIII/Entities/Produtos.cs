using System;
using System.Collections.Generic;
using System.Text;

namespace ModuloXIII.Entities
{
    class Produtos
    {
        public string NameProduto { get; set; }
        public double Valor { get; set; }

        public int Qtd { get; set; }

        public Produtos() { }
        public Produtos(string nameProduto, double valor, int qtd)
        {
            NameProduto = nameProduto;
            Valor = valor;
            Qtd = qtd;
        }

        public double CalcEstoque()
        {
            return Valor * Qtd;
        }
    }
}
