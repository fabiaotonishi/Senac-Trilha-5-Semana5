using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Modelos
{
    /// <summary>
    /// Classes de domínio/modelo da entidade cliente
    /// </summary>
    public class Cliente : ICliente
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Profissao { get; set; }
        public string Telefone { get; set; }
        public Endereco Endereco { get; set; }

        /// <summary>
        /// Método que identifica um cliente pelo Nome e o CPF
        /// </summary>
        /// <param name="nome">Nome</param>
        /// <param name="cpf">CPF</param>
        /// <returns></returns>
        public string Identificar(string nome, string cpf)
        {
            return $"NOME:{Nome} - CPF:{Cpf}";
        }
    }
}
