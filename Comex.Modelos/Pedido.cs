using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Modelos
{
    /// <summary>
    /// Classes de domínio/modelo da entidade pedido
    /// </summary>
    public class Pedido
    {
        public Cliente Cliente { get; set; }
        public DateTime Data { get; set; }
        public List<ItemDePedido> Itens { get; set; }        
        public double Total 
        { 
            get 
            {
                return Itens.Sum(item => item.Subtotal);
            } 
        }

        /// <summary>
        /// Método construtor do pedido
        /// </summary>
        /// <param name="cliente">Cliente</param>
        public Pedido(Cliente cliente)
        {
            Cliente = cliente;
            Data = DateTime.Now;
            Itens = new List<ItemDePedido>();
        }


        /// <summary>
        ///  Método para representar os valores do pedido em texto
        /// </summary>
        /// <returns>Retorna em texto com os dados do pedido</returns>
        public override string ToString()
        {
            return $"Cliente: {Cliente.Nome}, Data: {Data}, Total: {Total:F2}";
        }

        /// <summary>
        /// Método para adicionar os itens no pedido
        /// </summary>
        /// <param name="item">Item do pedido</param>
        public void AdicionarItem(ItemDePedido item)
        {
            if (item != null)
            {
                Itens.Add(item);
                //Total += item.Subtotal;
            }            
        }
    }
}
