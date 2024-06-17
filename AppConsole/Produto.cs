using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsole
{
    public class Produto
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double PrecoUnitario  { get; set; }
        public int Quantidade { get; set; }

        public Produto(string nome)
        {
            Nome = nome;
        }
    }
}
