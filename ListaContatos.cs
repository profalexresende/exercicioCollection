using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioCollection
{
    class ListaContatos
    {
        private List<Contato> contatos = new List<Contato>();

        public void VisualizarContatos()
        {
            if (contatos.Count == 0)
            {
                Console.WriteLine("Sem contatos para exibir...");
            }
            else
            {
                Console.WriteLine("Lista de Contatos:");
                for (int i = 0; i < contatos.Count; i++)
                {
                    Console.WriteLine($"{i}. Nome: {contatos[i].Nome}, Telefone: {contatos[i].Telefone}, " +
                        $"EMail: {contatos[i].EMail}");
                }
            }
        }

        public void AdicionarContato()
        {
            try
            {
                Console.WriteLine("Nome do contato:");
                string nome = Console.ReadLine();

                Console.WriteLine("Telefone:");
                string telefone = Console.ReadLine();

                Console.WriteLine("EMail:");
                string email = Console.ReadLine();

                contatos.Add(new Contato(nome,telefone,email));
                Console.WriteLine("Novo contato adicionado a sua agenda.");
            }
            
            catch (Exception ex)
            {
                Console.WriteLine($"Erro inesperado: {ex.Message}");
            }
        }

        public void ExcluirContato()
        {
            VisualizarContatos();
            Console.WriteLine("Digite o código do contato a excluir:");
            if (int.TryParse(Console.ReadLine(), out int indice) && indice >= 0 && indice < contatos.Count)
            {
                contatos.RemoveAt(indice);
                Console.WriteLine("Contato removido da agenda.");
            }
            else
            {
                Console.WriteLine("Índice inválido. Não foi possível excluir o contato.");
            }
        }
        public void AlterarContato()
        {
            VisualizarContatos();
            Console.WriteLine("Digite o código do contato a atualizar:");
            if (int.TryParse(Console.ReadLine(), out int indice) && indice >= 0 && indice < contatos.Count)
            {
                Console.WriteLine("Nome do contato:");
                contatos[indice].Nome = Console.ReadLine();

                Console.WriteLine("Novo Telefone:");
                contatos[indice].Telefone = Console.ReadLine();

                Console.WriteLine("Novo EMail:");
                contatos[indice].EMail = Console.ReadLine();

                Console.WriteLine("Dados do contato atualizados.");
            }
            else
            {
                Console.WriteLine("Índice inválido. Não foi possível atualizar o contato.");
            }
        }
    }
}
