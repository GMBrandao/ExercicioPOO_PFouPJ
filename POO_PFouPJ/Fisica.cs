using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_PFouPJ
{
    internal class Fisica : Pessoa
    {
        public long Cpf { get; set; }

        public Fisica(string nome, string endereco, string telefone, string telefone2, string email, long cpf) : base(nome, endereco, telefone, telefone2, email)
        {
            Cpf = cpf;
        }

        public override string ToString()
        {
            return base.ToString() + " - " + Cpf;
        }
    }
}
