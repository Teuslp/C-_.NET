namespace Todolist;

public class Lista
{
    private List<string> tarefas = new List<string>();

    public void Adicionar(string nomeTarefa)
    {
        tarefas.Add(nomeTarefa);
    }

    public List<string> ListarTarefas()
    {
        return tarefas;
    }

    public bool Remover(int opcaoRemover)
    {
        int indice = opcaoRemover - 1;

        if (indice < 0 || indice >= tarefas.Count)
            return false;

        tarefas.RemoveAt(indice);
        return true;
    }

    public bool TemTarefas()
    {
        return tarefas.Count > 0;
    }
}
