using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using Microsoft.AspNetCore.Http.HttpResults;
using ToDo_Simplify.Data;
using ToDo_Simplify.DTOs;

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
    
}