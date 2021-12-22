using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SolucaoWeb.Domain.Models;
using SolucaoWeb.Domain.Interfaces;
using SolucaoWeb.Infra.Context;

namespace SolucaoWeb.Infra.Repository
{
    public class TodoRepository : ITodoRepository
    {
        protected readonly AppDbContext _dbContext;

        public TodoRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Todo> GetTodoByIdAsync(int id)
        {
            return await _dbContext.Todos
                                   .AsNoTracking()
                                   .FirstOrDefaultAsync(t => t.Id == id);
        }
    }
}