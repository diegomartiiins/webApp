using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using webApp.Models;

namespace webApp.Data 
{
    public class AppDbContext : DbContext 
    {

        public AppDbContext(DbContextOptions<AppDbContext> options ) : base(options)
        {            
        }

        public DbSet<AutorModel> Autores {get; set;}
        public DbSet<LivroModel> Livros {get; set;}
    }
}