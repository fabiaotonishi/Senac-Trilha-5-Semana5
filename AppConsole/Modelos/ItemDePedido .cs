using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsole.Modelos
{
    public class ItemDePedido
    {
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public double PrecoUnitario { get; set; }
        public double Subtotal { get; private set; }

        public ItemDePedido(Produto produto, int quantidade, double precoUnitario)
        {
            Produto = produto;
            Quantidade = quantidade;
            PrecoUnitario = precoUnitario;
            Subtotal = quantidade * precoUnitario;
        }

        
        public override string ToString()
        {
            return $"Produto: {Produto.Nome}, Quantidade: {Quantidade}, Preço Unitário: {PrecoUnitario:F2}, Subtotal:{Subtotal:F2}";
        }
    }
}
