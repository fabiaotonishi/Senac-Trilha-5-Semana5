using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsole.Modelos
{
    public class Eletronico : Produto
    {
        public Eletronico(string nome) : base(nome)
        {
        }

        public int Voltagem { get; set; }
        public int Potencia { get; set; }
    }
}
