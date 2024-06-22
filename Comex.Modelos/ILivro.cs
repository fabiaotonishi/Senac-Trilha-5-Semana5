using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Modelos
{
    /// <summary>
    /// Classes de interface/contrato da entidade livro
    /// </summary>
    public interface ILivro
    {        
        string Identificar(string nome, string cpf);
    }
}
