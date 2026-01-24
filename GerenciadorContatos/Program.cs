namespace Gerenciador;

public class Program
{
    public static void Main()
    {

        int numero;
        var agenda = new Agenda();

        do
        {
            Console.WriteLine("===== GERENCIADOR DE CONTATOS =====");
            Console.WriteLine(
                "1 - Adicionar contato\n" +
                "2 - Listar contatos\n" +
                "3 - Buscar contato pelo nome\n" +
                "4 - Remover contato\n" +
                "5 - Sair");
            Console.Write("Escolha a opção: ");

            string opcao = Console.ReadLine();
            bool sucesso = int.TryParse(opcao, out numero);

            if (!sucesso)
            {
                Console.WriteLine("INVÁLIDO! Escolha de 1 a 5");
                continue;
            }

            switch (numero)
            {
                case 1:
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();

                    Console.Write("Telefone: ");
                    string telefone = Console.ReadLine();

                    Console.Write("Email: ");
                    string email = Console.ReadLine();

                    Contatos novoContato = new Contatos(nome, telefone, email);
                    agenda.Adicionar(novoContato);

                    Console.WriteLine("===== Contato adicionado com sucesso!=====");
                    break;

                case 2:
                    var contatos = agenda.ListarContatos();

                    if (contatos.Count == 0)
                    {
                        Console.WriteLine("===== Nenhum contato foi adicionado =====");
                        break;
                    }

                    for (int i = 0; i < contatos.Count; i++)
                    {
                        Console.WriteLine($"{i + 1} - {contatos[i].Nome} | {contatos[i].Telefone} | {contatos[i].Email}");
                    }
                    break;

                case 3:
                    Console.Write("Digite o nome do contato: ");
                    string nomeBuscado = Console.ReadLine();

                    Contatos contato = agenda.BuscarContato(nomeBuscado);

                    if (contato == null)
                    {
                        Console.WriteLine("===== Contato não encontrado =====");
                    }
                    else
                    {
                        Console.WriteLine("===== Contato encontrado =====");
                        Console.WriteLine($"Nome: {contato.Nome}");
                        Console.WriteLine($"Telefone: {contato.Telefone}");
                        Console.WriteLine($"Email: {contato.Email}");
                    }
                    break;


                case 4:
                    Console.Write("Qual contato quer remover? ");

                    if (int.TryParse(Console.ReadLine(), out int opcaoRemover))
                    {
                        if (agenda.Remover(opcaoRemover))
                        {
                            Console.WriteLine("===== Removido com sucesso! =====");
                        }
                        else
                        {
                            Console.WriteLine("===== Índice inválido =====");
                        }
                    }
                    break;

                case 5:
                    Console.WriteLine("Saindo....");
                    break;
            }

        } while (numero != 5);
    }
}