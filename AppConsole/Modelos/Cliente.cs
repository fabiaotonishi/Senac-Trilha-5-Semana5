using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsole.Modelos
{
    public class Cliente : ICliente
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Profissao { get; set; }
        public string Telefone { get; set; }
        public Endereco Endereco { get; set; }

        public string Identificar(string nome, string cpf)
        {
            return $"NOME:{Nome} - CPF:{Cpf}";
        }
    }
}
