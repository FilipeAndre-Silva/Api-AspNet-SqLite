using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SolucaoWeb.Domain.Interfaces;
using SolucaoWeb.Domain.Models;

namespace SolucaoWeb.Api.Controllers
{
    [Route("api/todo")]
    public class TodoController : ControllerBase
    {
        private readonly ITodoService _todoService;

        public TodoController(ITodoService todoService)
        {
            _todoService = todoService;
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<Todo>> GetByid(int id)
        {
            var todo = await _todoService.GetTodoByIdAsync(id);

            if (todo == null) return NotFound();

            return todo;
        }
    }
}