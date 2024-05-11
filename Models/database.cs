using Microsoft.EntityFrameworkCore;
using basilico.karol._5h.Ecommerce.Models;
public class dbContext : DbContext
{
    private readonly DbContextOptions? _options;
    public dbContext() { }

    protected override void
            OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=database.db");

    public DbSet<Utente> Utenti { get; set; }
       

        public string? Nome{ get; set; }


}