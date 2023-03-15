using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_PFouPJ
{
    internal class Juridica : Pessoa
    {
        public long Cnpj { get; set; }
        public string NomeFantasia { get; set; }

        public Juridica(string nome, string endereco, string telefone, string telefone2, string email, long cnpj, string nomefantasia) :base(nome, endereco, telefone, telefone2, email)
        {
            Cnpj = cnpj;
            NomeFantasia = nomefantasia;
        }

        public override string ToString()
        {
            return base.ToString() + " - " + Cnpj + " - " + NomeFantasia;
        }
    }
}
