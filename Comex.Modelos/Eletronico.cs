using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Modelos
{
    /// <summary>
    /// Classes de domínio/modelo da entidade eletrônico
    /// </summary>
    public class Eletronico : Produto
    {
        /// <summary>
        /// Método construtor do eletrônico
        /// </summary>
        /// <param name="nome">Nome</param>
        public Eletronico(string nome) : base(nome)
        {
        }

        public int Voltagem { get; set; }
        public int Potencia { get; set; }
    }
}
