using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Modelos
{
    /// <summary>
    /// Classes de domínio/modelo da entidade livro
    /// </summary>
    public class Livro : Produto, ILivro
    {
        /// <summary>
        /// Método construtor do livro
        /// </summary>
        /// <param name="nome"></param>
        public Livro(string nome) : base(nome)
        {
        }

        public string Isbn { get; set; }
        public int TotalPaginas { get; set; }


        /// <summary>
        /// Método para identificar um cliente pelo Nome e o ISBN
        /// </summary>
        /// <param name="nome">Nome</param>
        /// <param name="isbn">ISBN</param>
        /// <returns></returns>
        public string Identificar(string nome, string isbn)
        {
            return $"NOME:{Nome} - ISBN:{isbn}";
        }
    }
}
