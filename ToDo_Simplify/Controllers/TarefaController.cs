using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using Microsoft.AspNetCore.Http.HttpResults;
using ToDo_Simplify.Data;

namespace ToDo_Simplify.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TarefaController : ControllerBase
{
    private ToDoContext _context;

    public TarefaController(ToDoContext context)
    {
        _context = context;
    }

    [HttpGet("testar-conexao")]
    public IActionResult TestarConexao()
    {
        try
        {
            var primeiraTarefa = _context.Tarefa.FirstOrDefault();

            if (primeiraTarefa is not null)
            {
                return Ok("Conexão com o banco de dados estabelecida com sucesso!");
            }
            else
            {
                return NotFound("Não foi possível encontrar nenhuma tarefa. Verifique sua conexão com o banco de dados.");
            }
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Erro ao conectar ao banco de dados: {ex.Message}");
        }
    }
}