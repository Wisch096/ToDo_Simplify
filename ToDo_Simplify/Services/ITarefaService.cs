using ToDo_Simplify.DTOs;

namespace ToDo_Simplify.Services;

public interface ITarefaService
{
    Task<IEnumerable<TarefaDTO>> GetAllTarefas();
    Task<TarefaDTO> GetTarefaById(int id);
    Task<TarefaDTO> CreateTarefa(TarefaDTO tarefaDTO);
    Task<bool> UpdateTarefa(int id, TarefaDTO tarefaDTO);
    Task<bool> DeleteTarefa(int id);
}
