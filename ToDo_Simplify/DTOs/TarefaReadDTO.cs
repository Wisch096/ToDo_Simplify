namespace ToDo_Simplify.DTOs;

public class TarefaReadDTO
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public bool Realizado { get; set; }
    public int Prioridade { get; set; }
}