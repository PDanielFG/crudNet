using Microsoft.EntityFrameworkCore;


//Puente entre mi app y la bd
namespace crudNetNet
{
    public class ApplicationDbContext : DbContext       // :EntityFramework 
    {
        //constructor para recibir la config(connectionString...) y pasarla a EntityFramework
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        //Configura la bd manualamente
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        //Esta clase representa una tabla en la bd, como solo hay una tabla ejemplos pues solo una clase
        public DbSet<Ejemplo> Ejemplo{ get; set; }

    }

}
