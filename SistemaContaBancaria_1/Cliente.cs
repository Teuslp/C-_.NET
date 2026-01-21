namespace Banco;

public class Cliente
{
    private string Nome;
    private string Cpf;

    public Cliente(string cpfUser, string nomeUser)
    {
        Cpf = cpfUser;
        Nome = nomeUser;
    }

    public string NomeCliente()
    {
         return Nome;
    }

    public string CpfCliente()
    {
        return Cpf;
    }
}