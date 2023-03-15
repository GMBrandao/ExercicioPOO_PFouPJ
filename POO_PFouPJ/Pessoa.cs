using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_PFouPJ
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }
        public string Telefone {  get; set; }
        public string Telefone2 { get; set; }

        public Pessoa(string nome, string endereco, string telefone, string telefone2, string email)
        {
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
            Telefone2 = telefone2;
            Email = email;
        }

        public override string ToString()
        {
            return (Nome + " - " + Endereco + " - " + Telefone + " - " + Telefone2 + " - " + Email);
        }

    }
}
