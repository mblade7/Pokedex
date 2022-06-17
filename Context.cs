using Microsoft.EntityFrameworkCore;

public class Context : DbContext
{
    public Context() : base() { }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // connect to sqlite database
        options.UseSqlite(@"Data Source=Pokedex.db");
    }

    public DbSet<Pokemon>Pokemon {get;set;}
}