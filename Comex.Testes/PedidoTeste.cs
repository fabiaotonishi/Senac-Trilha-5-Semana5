using Comex.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Comex.Testes
{
    public class PedidoTeste
    {
        [Fact]
        public void PedidoDeveInicializarComCliente()
        {
            //Arrange
            var cliente = new Cliente
            {
                Nome = "Teste"
            };

            //Act
            var pedido = new Pedido(cliente);

            //Assert
            Assert.Equal(cliente, pedido.Cliente);
            Assert.Empty(pedido.Itens);
            Assert.Equal(0, pedido.Total);
        }

        [Theory]
        [InlineData("Produto A", 100.0, 1)]
        public void AdicionarItemDeveAdicionarItemEAtualizarTotal(string nomeProduto, double precoUnitario, int quantidade)
        {
            //Arrange
            var cliente = new Cliente
            {
                Nome = "Teste"
            };
            var pedido = new Pedido(cliente);
            var produto = new Produto(nomeProduto)
            {
                PrecoUnitario = precoUnitario,
            };
            var item = new ItemDePedido(produto, quantidade, precoUnitario);
            var totalEsperado = precoUnitario * quantidade;

            //Act
            pedido.AdicionarItem(item);

            //Assert
            Assert.Contains(item, pedido.Itens);
            Assert.Equal(totalEsperado, pedido.Total);
        }

        [Theory]
        [InlineData("Produto B", 200.0, 2)]
        public void ToStringDeveRetornarStringCorreta(string nomeProduto, double precoUnitario, int quantidade)
        {
            //Arrange
            var cliente = new Cliente
            {
                Nome = "Teste"
            };
            var pedido = new Pedido(cliente);
            var produto = new Produto(nomeProduto)
            {
                PrecoUnitario = precoUnitario,
            };
            var item = new ItemDePedido(produto, quantidade, precoUnitario);
            pedido.AdicionarItem(item);
            var stringEsperada = $"Cliente: {pedido.Cliente.Nome}, Data: {pedido.Data}, Total: {pedido.Total:F2}";

            //Act
            var stringResultado = pedido.ToString();

            //Assert
            Assert.Equal(stringEsperada, stringResultado);
        }
    }


}
