using ApiWebInformaticaDP.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiWebInformaticaDP.Context
{
    public class AppDbContext : DbContext // -> Usa sesion con la base de datos.
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
                        
        }

        public DbSet<Person> Persons { get; set; } // -> Representa la tabla Person en la base de datos.
    }
}
