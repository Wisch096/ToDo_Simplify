using ToDo_Simplify.DTOs;

namespace ToDo_Simplify.Services;

public interface ITarefaService
{
    Task<IEnumerable<TarefaReadDTO>> GetAllTarefas();
    Task<TarefaReadDTO> GetTarefaById(int id);
    Task<TarefaReadDTO> CreateTarefa(TarefaDTO tarefaDto);
    Task<bool> UpdateTarefa(int id, TarefaDTO tarefaDto);
    Task<bool> DeleteTarefa(int id);
    
}