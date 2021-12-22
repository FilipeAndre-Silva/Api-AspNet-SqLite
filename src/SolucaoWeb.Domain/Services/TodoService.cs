using System.Threading.Tasks;
using SolucaoWeb.Domain.Models;
using SolucaoWeb.Domain.Interfaces;

namespace SolucaoWeb.Domain.Services
{
    public class TodoService : ITodoService
    {
        private readonly ITodoRepository _todoRepository;
        public TodoService(ITodoRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }

        public async Task<Todo> GetTodoByIdAsync(int id)
        {
            return await _todoRepository.GetTodoByIdAsync(id);
        }
    }
}