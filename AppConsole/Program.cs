// See https://aka.ms/new-console-template for more information
using AppConsole.Modelos;
using System;
using System.Text.Json;

/*---------------------------------------------- */
Console.Clear();
Console.WriteLine("Hello, World!");
Console.ReadKey();

/*---------------------------------------------- */
Console.Clear();
Teste teste = new Teste();
teste.Executar();
Console.ReadKey();

/*---------------------------------------------- */
List<Produto> listaProdutos = new List<Produto>() 
{ 
    new Produto()
    { 
        Nome = "Teste",
        Descricao = "Produto de teste",
        PrecoUnitario = 1.00,
        Quantidade = 0,
    }
};

List<Pedido> listaPedidos = new List<Pedido>();

ExibeMenuAsync();

void ExibeMenuAsync()
{
	var numero=0;
    Inicio:
    Console.Clear();
    Console.WriteLine("Informe o numero: " +
        "(1) Criar Produto " +
        "(2) Listar Produtos " +
        "(3) Buscar Produto Externo" +
        "(4) Criar Pedido" +
        "(5) Listar Pedidos");
	if (!Int32.TryParse(Console.ReadLine(), out numero))
	{
        Console.WriteLine("Informe um numero!");
        goto Inicio;
    }
	
	switch (numero)
	{
		case 1:
			CriarProduto();
			break;
		case 2:
			ListarProduto();
			break;
        case 3:
            BuscarProdutoAsync().Wait();
            break;
        case 5:
            CriarPedido();
            break;
        case 6:
            ListarPedido();
            break;
        default:
			Console.WriteLine("Escolha uma opção válida!");
			goto Inicio;
			break;
	}
}

void CriarProduto()
{
	string nome;
	string descricao;
	double precoUnitario;
	int quantidade;
	Console.Clear();
    Console.WriteLine("Para criar um produto informe: \n");
    Console.WriteLine("Nome");
	nome = Console.ReadLine();
    Console.WriteLine("Descrição");
    descricao = Console.ReadLine();
    Console.WriteLine("Preço Unitário");
	if (!double.TryParse(Console.ReadLine(), out precoUnitario))
	{
		precoUnitario = 0;
	}
    Console.WriteLine("Quantidade");
    if (!int.TryParse(Console.ReadLine(), out quantidade))
    {
        quantidade = 0;
    }    
    Produto produto = new Produto(nome);
	produto.Descricao = descricao;
	produto.PrecoUnitario = precoUnitario;
	produto.Quantidade = quantidade;
	listaProdutos.Add(produto);
    Console.WriteLine("Produto criado com sucesso!");
    Console.WriteLine("Pressione uma tecla para voltar ao menu. \n");
	Console.ReadKey();
	ExibeMenuAsync();
}

void ListarProduto()
{
	Console.Clear();
    Console.WriteLine("Lista de Produtos:");
	foreach (var produto in listaProdutos)
	{
		Console.WriteLine($"\n Nome: {produto.Nome} Descrição: {produto.Descricao} Preço Unitário {produto.PrecoUnitario} Quantidade {produto.Quantidade}");        
    }
    Console.WriteLine("Pressione uma tecla para voltar ao menu. \n");
    Console.ReadKey();
    ExibeMenuAsync();
}

async Task BuscarProdutoAsync()
{
    using (HttpClient clientHttp = new HttpClient())
    {
        try
        {
            string resposta = await clientHttp.GetStringAsync("https://fakestoreapi.com/products");
            //Console.WriteLine(resposta);
            listaProdutos = JsonSerializer.Deserialize<List<Produto>>(resposta)!;
            ListarProduto();
            Console.WriteLine("Pressione uma tecla para voltar ao menu. \n");
            Console.ReadKey();
            ExibeMenuAsync();

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu um problema: {ex.Message}");
        }
    }

}
void CriarPedido()
{
    
    Console.Clear();
    Console.WriteLine("Para criar um pedido informe: \n");
    Console.WriteLine("Nome");
    var nome = Console.ReadLine();
    Cliente cliente = new Cliente()
    {
        Nome = nome
    };
    var pedido = new Pedido(cliente);
    
    Console.WriteLine("Produto disponíveis");
    for (int i = 0; i < listaProdutos.Count; i++)
    {
        Console.WriteLine($"{i + 1} - {listaProdutos[i].Nome}");
    }
    Console.WriteLine("Informe o número do produto para adicionar:");
    Produto:
    var numeroProduto = 0;
    if (!int.TryParse(Console.ReadLine(), out numeroProduto))
    {
        Console.WriteLine("Numero inválido");
        goto Produto;
    }
    var produto = listaProdutos[numeroProduto - 1];

    Quantidade:
    var quantidade = 0;
    Console.WriteLine("Quantidade");
    if (!int.TryParse(Console.ReadLine(), out quantidade))
    {
        Console.WriteLine("Quantidade inválida");
        goto Quantidade;
    }
    
    var itemPedido = new ItemDePedido(produto, quantidade, produto.PrecoUnitario);
    pedido.AdicionarItem(itemPedido);
    listaPedidos.Add(pedido);
    Console.WriteLine("Pedido criado com sucesso!");
    Console.WriteLine("Pressione uma tecla para voltar ao menu. \n");
    Console.ReadKey();
    ExibeMenuAsync();
}


void ListarPedido()
{
    Console.Clear();
    Console.WriteLine("Lista de Pedidos:");
    foreach (var pedidos in listaPedidos)
    {
        Console.WriteLine($"{pedidos.ToString()}");
    }
    Console.WriteLine("Pressione uma tecla para voltar ao menu. \n");
    Console.ReadKey();
    ExibeMenuAsync();
}


