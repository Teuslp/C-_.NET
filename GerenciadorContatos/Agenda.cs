namespace Gerenciador;

public class Agenda
{
    private List<Contatos> contatos = new List<Contatos>();

    public void Adicionar(Contatos contato)
    {
        contatos.Add(contato);
    }

    public List<Contatos> ListarContatos()
    {
        return contatos;
    }

    public Contatos BuscarContato(string nome)
    {
        return contatos.FirstOrDefault(c =>
            c.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
    }


    public bool Remover(int opcaoRemover)
    {
        int indice = opcaoRemover - 1;

        if (indice < 0 || indice >= contatos.Count)
            return false;

        contatos.RemoveAt(indice);
        return true;
    }

    public bool TemContatos()
    {
        return contatos.Any();
    }

}