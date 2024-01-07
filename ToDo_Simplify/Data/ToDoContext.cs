using Microsoft.EntityFrameworkCore;
using ToDo_Simplify.Models;

namespace ToDo_Simplify.Data;

public class ToDoContext : DbContext
{
    public ToDoContext(DbContextOptions<ToDoContext> options) : base(options)
    {
        
    } 
    
    public DbSet<Tarefa> Tarefa { get; set; }
    
}