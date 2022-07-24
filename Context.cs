using Microsoft.EntityFrameworkCore;
using System.Text.Json;

public class Context : DbContext
{
    public Context() : base() { }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // connect to sqlite database
        options.UseSqlite(@"Data Source=Pokedex.db");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        List<Pokemon> source = new List<Pokemon>();
        List<Moves> source2= new List<Moves>();

        using (StreamReader p = new StreamReader("Pokemon.json"))
        {
            string json = p.ReadToEnd();
            source = JsonSerializer.Deserialize<List<Pokemon>>(json);
        }
        foreach (Pokemon p in source)
        {
           modelBuilder.Entity<Pokemon>().HasData(
           new Pokemon
           {
               DexNum = p.DexNum,
               Name = p.Name,
               Japanese_Name = p.Japanese_Name,
               Type1 = p.Type1,
               Type2 = p.Type2,
               Base_HP = p.Base_HP,
               Base_ATK = p.Base_ATK,
               Base_DEF = p.Base_DEF,
               Base_SPC = p.Base_SPC,
               Base_SPD = p.Base_SPD,
               Catch_Rate = p.Catch_Rate,
               RedBlueDex = p.RedBlueDex,
               YellowDex =  p.YellowDex,
           }
       );
            base.OnModelCreating(modelBuilder);
        }
        using (StreamReader m = new StreamReader("Moves.json"))
        {
            string json = m.ReadToEnd();
            source2 = JsonSerializer.Deserialize<List<Moves>>(json);
        }
        foreach (Moves m in source2)
        {
            modelBuilder.Entity<Moves>().HasData(
            new Moves
            {
                ID = m.ID,
                Name = m.Name,
                Type = m.Type,
                Power = m.Power,
                StartPP = m.StartPP,
                Accuracy= m.Accuracy,
                Effect= m.Effect,
            }
        );
            base.OnModelCreating(modelBuilder);
        }
    }

    public DbSet<Pokemon>Pokemon {get;set;}
    public DbSet<Moves> Moves {get;set;}
}