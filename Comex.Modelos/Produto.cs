using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace Comex.Modelos
{
    /// <summary>
    /// Classes de domínio/modelo da entidade produto
    /// </summary>
    public class Produto
    {
        [JsonPropertyName("title")]
        public string? Nome { get; set; }

        [JsonPropertyName("description")]
        public string? Descricao { get; set; }

        [JsonPropertyName("price")]
        public double PrecoUnitario { get; set; }

        public int Quantidade { get; set; }

        /// <summary>
        /// Método construtor do produto
        /// </summary>
        /// <param name="nome">NOme</param>

        public Produto(string nome)
        {
            Nome = nome;
        }

        /// <summary>
        /// Método construtor do produto
        /// </summary>
        public Produto()
        {
                
        }
    }
}
