using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsole.Modelos
{
    public interface ICliente
    {
        string Identificar(string nome, string cpf);
    }
}
