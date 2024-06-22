using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Modelos
{
    /// <summary>
    /// Classes de domínio/modelo da entidade endereço
    /// </summary>
    public class Endereco
    {
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Complemento { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
    }
}
