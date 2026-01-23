namespace Todolist;

public class Program
{
    public static void Main()
    {
        int numero;
        var lista = new Lista();

        do
        {
            Console.WriteLine("=====SISTEMA DE TAREFAS=====");
            Console.WriteLine(
                "1 - Adicionar tarefa\n" +
                "2 - Listar tarefas\n" +
                "3 - Remover tarefa\n" +
                "4 - Sair\n");

            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine() ?? "";
            bool sucesso = int.TryParse(opcao, out numero);

            if (!sucesso)
            {
                Console.WriteLine("Opção inválida!");
                continue;
            }

            switch (numero)
            {
                case 1:
                    Console.Write("Digite o nome da sua tarefa: ");
                    string nome = Console.ReadLine() ?? "";
                    lista.Adicionar(nome);
                    Console.WriteLine("ADICIONADA COM SUCESSO!");
                    break;

                case 2:
                    var tarefas = lista.ListarTarefas();

                    if (tarefas.Count == 0)
                    {
                        Console.WriteLine("Nenhuma tarefa cadastrada.");
                        break;
                    }

                    for (int i = 0; i < tarefas.Count; i++)
                    {
                        Console.WriteLine($"{i + 1} - {tarefas[i]}");
                    }
                    break;

                case 3:
                    Console.Write("Digite o número da tarefa a remover: ");

                    if (int.TryParse(Console.ReadLine(), out int opcaoRemover))
                    {
                        if (lista.Remover(opcaoRemover))
                        {
                            Console.WriteLine("REMOVIDO COM SUCESSO");
                        }
                        else
                        {
                            Console.WriteLine("Erro: índice inválido.");
                        }
                    }
                    break;

                case 4:
                    Console.WriteLine("SAINDO...");
                    break;
            }

        } while (numero != 4);
    }
}
