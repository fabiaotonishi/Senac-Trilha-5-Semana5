// See https://aka.ms/new-console-template for more information
using AppConsole;

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
List<Produto> listaProdutos = new List<Produto>();
ExibeMenu();

void ExibeMenu()
{
	var numero=0;
    Inicio:
    Console.Clear();
    Console.WriteLine("Informe o numero: (1) Criar Produto ou (2) Listar Produtos");
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
    Console.WriteLine("Para criar um produto informe:");
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
	ExibeMenu();
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
    ExibeMenu();
}


