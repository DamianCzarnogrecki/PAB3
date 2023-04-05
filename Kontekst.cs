using PAB3;
using System.Data.Entity;

public class Kontekst : DbContext
{
    public Kontekst(string connectionString) : base(connectionString) { }

    public DbSet<Kody_Pocztowe> KodyPocztowe { get; set; }
}