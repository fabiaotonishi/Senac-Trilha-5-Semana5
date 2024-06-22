using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Modelos
{
    /// <summary>
    /// Classes de domínio/modelo da entidade de item do pedido
    /// </summary>
    public class ItemDePedido
    {
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public double PrecoUnitario { get; set; }
        public double Subtotal { get; private set; }

        /// <summary>
        /// Método construtor do item do pedido
        /// </summary>
        /// <param name="produto">Produto</param>
        /// <param name="quantidade">Quantidade</param>
        /// <param name="precoUnitario">Preço Unitário</param>
        public ItemDePedido(Produto produto, int quantidade, double precoUnitario)
        {
            Produto = produto;
            Quantidade = quantidade;
            PrecoUnitario = precoUnitario;
            Subtotal = quantidade * precoUnitario;
        }

        /// <summary>
        ///  Método que representa os valores do item do pedido em texto
        /// </summary>
        /// <returns>Retorna em texto com os dados do item do pedido</returns>
        public override string ToString()
        {
            return $"Produto: {Produto.Nome}, Quantidade: {Quantidade}, Preço Unitário: {PrecoUnitario:F2}, Subtotal:{Subtotal:F2}";
        }
    }
}
