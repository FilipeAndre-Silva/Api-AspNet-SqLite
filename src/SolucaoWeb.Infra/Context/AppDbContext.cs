using Microsoft.EntityFrameworkCore;
using SolucaoWeb.Domain.Models;

namespace SolucaoWeb.Infra.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Todo> Todos { get; set; }
    }
}