using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioCollection
{
    class Contato
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string EMail { get; set; }

        public Contato()
        {
            Nome = "";
            Telefone = "";
            EMail = "";
        }
        public Contato (string nome,string telefone, string email)
        {
            Nome = nome;
            Telefone = telefone;  
            EMail = email;
        }
    }
}
