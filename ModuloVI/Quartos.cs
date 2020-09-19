using System;
using System.Collections.Generic;
using System.Text;

namespace ModuloVI
{
    class Quartos
    {

        public int Quarto { get; set; }
        public String Nome{ get; set; }
        public String Email { get; set; }
        
        public Quartos(int quarto, string nome, string email)
        {
            Quarto = quarto;
            Nome = nome;
            Email = email;
        }
        public override string ToString()
        {
            return Quarto+": "+Nome+", "+Email;
        }
    }
}
