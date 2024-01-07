using ToDo_Simplify.Data;
using ToDo_Simplify.DTOs;
using ToDo_Simplify.Models;

namespace ToDo_Simplify.Services;

public class TarefaService : ITarefaService
{
    private readonly ToDoContext _context;

    public TarefaService(ToDoContext context)
    {
        _context = context;
    }
    
    public Task<IEnumerable<TarefaDTO>> GetAllTarefas()
    {
        throw new NotImplementedException();
    }

    public Task<TarefaDTO> GetTarefaById(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<TarefaDTO> CreateTarefa(TarefaDTO tarefaDTO)
    {
        var novaTarefa = new Tarefa
        {
            Nome = tarefaDTO.Nome,
            Descricao = tarefaDTO.Descricao,
            Realizado = tarefaDTO.Realizado,
            Prioridade = tarefaDTO.Prioridade
        };

        _context.Tarefa.Add(novaTarefa);
        await _context.SaveChangesAsync();
        
        return tarefaDTO;
    }

    public Task<bool> UpdateTarefa(int id, TarefaDTO tarefaDTO)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteTarefa(int id)
    {
        throw new NotImplementedException();
    }
}