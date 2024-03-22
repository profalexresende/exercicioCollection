// See https://aka.ms/new-console-template for more information
using exercicioCollection;
ListaContatos listaContatos = new ListaContatos();
while (true)
{
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("1. Visualizar contatos cadastrados");
    Console.WriteLine("2. Adicionar novo contato");
    Console.WriteLine("3. Excluir contato");
    Console.WriteLine("4. Alterar contato");
    Console.WriteLine("5. Sair");
    int opcao;
    if (!int.TryParse(Console.ReadLine(), out opcao))
    {
        Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
        continue;
    }
    switch (opcao)
    {
        case 1:
            listaContatos.VisualizarContatos();
            break;
        case 2:
            listaContatos.AdicionarContato();
            break;
        case 3:
            listaContatos.ExcluirContato();
            break;
        case 4:
            listaContatos.AlterarContato();
            break;
        case 5:
            Console.WriteLine("Saindo do programa.");
            return;
        default:
            Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
            break;
    }
    Console.WriteLine("Digite qualquer tecla para continuar...");
    Console.ReadKey();
    Console.Clear();
}
