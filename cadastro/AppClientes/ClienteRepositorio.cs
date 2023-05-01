using cadastro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class ClienteRepositorio
    {
        public List<Cliente> clientes = new List<Cliente>();

        //Create
        public void CadastrarCliente()
        {
            Console.Clear();

            Console.Write("Nome Do Cliente >>> ");
            var nome = Console.ReadLine();
            Console.Write(Environment.NewLine);

            Console.Write("Data de Nascimento ");
            var dataNascimento = DateOnly.Parse(Console.ReadLine());
            Console.Write(Environment.NewLine);

            Console.Write("Desconto ");
            var desconto =decimal.Parse(Console.ReadLine());
            Console.Write(Environment.NewLine);


            var cliente = new Cliente();
            cliente.Id = clientes.Count + 1;
            cliente.Nome = nome;
            cliente.DataNascimento = dataNascimento;
            cliente.Desconto = desconto;
            cliente.Cadastrado = DateTime.Now;

            clientes.Add(cliente);
            Console.WriteLine("Cadastrado Com Sucesso");
            imprimirCliente(cliente);
            Console.ReadKey();

        }

        //Read
        public void ExibirClientes()
        {
            Console.Clear();

            foreach (var cliente in clientes)
            {
                imprimirCliente(cliente);
            }
            Console.ReadKey();

        }


        public void EditarCliente()
        {
            Console.Clear();
            Console.Write("Informe o codigo do Cliente ");
            var codigo = Console.ReadLine();
            Console.ReadKey();

            var cliente = clientes.FirstOrDefault(p => p.Id == int.Parse(codigo));

            if (cliente == null)
            {
                Console.WriteLine("Cliente Nao encontrado! [Enter] ");
                Console.ReadKey();
                return;
            }

            imprimirCliente(cliente);

            Console.Write("Nome Do Cliente >>> ");
            var nome = Console.ReadLine();
            Console.Write(Environment.NewLine);

            Console.Write("Data de Nascimento ");
            var dataNascimento = DateOnly.Parse(Console.ReadLine());
            Console.Write(Environment.NewLine);

            Console.Write("Desconto ");
            var desconto = decimal.Parse(Console.ReadLine());
            Console.Write(Environment.NewLine);

            cliente.Nome = nome;
            cliente.DataNascimento = dataNascimento;
            cliente.Desconto = desconto;
            cliente.Cadastrado = DateTime.Now;

            
            Console.WriteLine("Cliente Alterado Com Sucesso");
            imprimirCliente(cliente);
            Console.ReadKey();
        }

        public void excluirCliente()
        {
            Console.Clear();
            Console.Write("Informe o código do Cliente: ");

            int codigo;
            while (!int.TryParse(Console.ReadLine(), out codigo))
            {
                Console.WriteLine("Código inválido. Por favor, informe um número inteiro válido.");
                Console.Write("Informe o código do Cliente: ");
            }

            var cliente = clientes.FirstOrDefault(p => p.Id == codigo);

            if (cliente == null)
            {
                Console.WriteLine("Cliente não encontrado. [Enter]");
                Console.ReadKey();
                return;
            }

            imprimirCliente(cliente);

            clientes.Remove(cliente);

            Console.WriteLine("Cliente excluído com sucesso.");
            Console.ReadKey();
        }

        //List
        public void imprimirCliente(Cliente cliente)
        {
            Console.WriteLine("--------------------");

            Console.WriteLine("ID.................. " + cliente.Id);

            Console.WriteLine("Nome................ " + cliente.Nome);

            Console.WriteLine("Desconto............ " + cliente.Desconto.ToString("0.00"));

            Console.WriteLine("Data De Nascimento.. " + cliente.DataNascimento);

            Console.WriteLine("Data Cadastro....... " + cliente.Cadastrado);

            Console.WriteLine("--------------------");

        }
    }
}
