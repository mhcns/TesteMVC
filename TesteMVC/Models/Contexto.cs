using Microsoft.EntityFrameworkCore;

public class Contexto : DbContext
{
    public virtual DbSet<Categoria> Categorias {get;set;}
    public DbSet<Produto> Produtos { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(connectionString:@"Server=(localdb)\mssqllocaldb;Database=Cursomvc;Integrated Security=True");
    }
}