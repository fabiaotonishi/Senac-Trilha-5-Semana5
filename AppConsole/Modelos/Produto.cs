using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace AppConsole.Modelos
{
    public class Produto
    {
        [JsonPropertyName("title")]
        public string? Nome { get; set; }

        [JsonPropertyName("description")]
        public string? Descricao { get; set; }

        [JsonPropertyName("price")]
        public double PrecoUnitario { get; set; }

        public int Quantidade { get; set; }

        public Produto(string nome)
        {
            Nome = nome;
        }

        public Produto()
        {
                
        }
    }
}
