using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsole.Modelos
{
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

        public Pedido(Cliente cliente)
        {
            Cliente = cliente;
            Data = DateTime.Now;
            Itens = new List<ItemDePedido>();
        }

        public override string ToString()
        {
            return $"Cliente: {Cliente.Nome}, Data: {Data}, Total: {Total:F2}";
        }

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
