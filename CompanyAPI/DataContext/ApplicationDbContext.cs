using CompanyAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CompanyAPI.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<FuncionarioModel> Funcionario { get; set; }
    }
}
