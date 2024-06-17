using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsole
{
    public class Teste
    {
        Endereco endereco;
        Cliente cliente;

        public Teste()
        {
            endereco = new Endereco();
            endereco.Bairro = "Centro";
            endereco.Cidade = "S. J. Rio Preto";
            endereco.Complemento = "Apartamento";
            endereco.Rua = "Rua Teste";
            endereco.Numero = 123;

            cliente = new Cliente();
            cliente.Nome = "Fulano de Tal";
            cliente.Cpf = "000.000.000-00";
            cliente.Email = "fulano.tal@teste.com.br";
            cliente.Profissao = "Docente";
            cliente.Telefone = "(00) 00000 0000";
            cliente.Endereco = endereco;          
        }

        public void Executar()
        {
            Console.WriteLine("Cliente");
            Console.WriteLine("Nome: {0}", cliente.Nome);
            Console.WriteLine("CPF: {0}", cliente.Cpf);
            Console.WriteLine("E-mail: {0}", cliente.Nome);
            Console.WriteLine("Profissão: {0}", cliente.Profissao);
            Console.WriteLine("Telefone: {0}", cliente.Telefone);
            Console.WriteLine("Endereço do cliente");
            Console.WriteLine("Bairro: {0}", cliente.Endereco.Bairro);
            Console.WriteLine("Cidade: {0}", cliente.Endereco.Cidade);
            Console.WriteLine("Complemento: {0}", cliente.Endereco.Complemento);
            Console.WriteLine("Rua: {0}", cliente.Endereco.Rua);
            Console.WriteLine("Numero: {0}", cliente.Endereco.Numero);
        }
    }
}
