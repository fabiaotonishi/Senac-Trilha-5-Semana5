using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsole.Modelos
{
    public class LIvro : Produto, ILivro
    {
        public LIvro(string nome) : base(nome)
        {
        }

        public string Isbn { get; set; }
        public int TotalPaginas { get; set; }

        public string Identificar(string nome, string cpf)
        {
            return $"NOME:{Nome} - ISBN:{Isbn}";
        }
    }
}
