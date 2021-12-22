using System.Threading.Tasks;
using SolucaoWeb.Domain.Models;

namespace SolucaoWeb.Domain.Interfaces
{
    public interface ITodoService
    {
        Task<Todo> GetTodoByIdAsync(int id);
    }
}