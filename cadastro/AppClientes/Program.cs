using Repositorio;

public class MenuPrincipal
{       
    static ClienteRepositorio _clienteRepositorio = new ClienteRepositorio();
    static void Main(string[] args)
    {
        while (true)
        {
            menu();

            //Evita a aplicacao ficar em loop sem fim, aguardando assim o usuario digitar uma tecla
            Console.ReadKey();
        }
    }

    static void menu()
    {
        Console.Clear();

        Console.WriteLine("Cadastro de Clientes ");

        Console.WriteLine("----------------------------");

        Console.WriteLine("1 - Cadastrar Cliente  ");

        Console.WriteLine("2 - Exibir Clientes  ");

        Console.WriteLine("3 - Editar Cliente ");

        Console.WriteLine("4 - Excluir Cliente ");

        Console.WriteLine("5 - Sair ");

        Console.WriteLine("----------------------------");

        MenuOpcoes();


    }

    public static void MenuOpcoes()
    {
        Console.WriteLine("Selecione uma opção:");

        int opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                _clienteRepositorio.CadastrarCliente();
                menu();
                break;

            case 2:
                _clienteRepositorio.ExibirClientes();
                menu();
                break;
                

            case 3:
                _clienteRepositorio.EditarCliente();
                menu();
                break;

            case 4:
                _clienteRepositorio.excluirCliente();
                menu();
                break;

            case 5:
                Environment.Exit(0);
                break;

            default:
                Console.WriteLine("Opção inválida.");
                Console.Clear();
                break;
        }
    }
}