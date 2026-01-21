namespace Banco;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("=========Registro Conta Bancária=========");
        Console.Write("Nome do títular: ");
        string nome = Console.ReadLine();

        Console.Write("Cpf do títular: ");
        string cpf = Console.ReadLine();
        var cliente = new Cliente(cpf, nome);

        Console.WriteLine("\n=========Cadastro Concluído=========\n");
        int opcao = 0;

        var conta = new Conta();
        double valor;

        do
        {

            Console.WriteLine("1 - Depositar\n" +
                              "2 - Sacar\n" +
                              "3 - Mostrar saldo\n" +
                              "4 - Mostrar dados do cliente\n" +
                              "5 - Sair");
            Console.Write("Escolha uma opção: \n");
            opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:

                    Console.Write("Digite o valor: ");
                    if (double.TryParse(Console.ReadLine(), out valor))
                    {
                        if (conta.Depositar(valor))
                            Console.WriteLine("Valor depositado com sucesso!");
                        else
                            Console.WriteLine("Valor inválido para depósito.");
                    }
                    break;

                case 2:

                    Console.Write("Digite o valor: ");
                    if (double.TryParse(Console.ReadLine(), out valor))
                    {
                        if (conta.Sacar(valor))
                        {
                            Console.WriteLine("Saque realizado com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Valor inválido para saque!");
                        }
                    }
                    break;

                case 3:
                    Console.WriteLine($"Seu saldo: R$ {conta.ExibirSaldo()}");
                    break;

                case 4:
                    Console.WriteLine($"=====Seus dados=====\n"+
                                      $"Nome: {cliente.NomeCliente()}\n"+
                                      $"Cpf: {cliente.CpfCliente()}");
                    break;

                case 5:
                    Console.WriteLine("Obriado por usar o app!");
                    break;
            }

        } while (opcao != 5);
    }
}