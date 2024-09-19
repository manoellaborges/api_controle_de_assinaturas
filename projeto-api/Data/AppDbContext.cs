using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<ControleDeAssinaturasModel> ControleDeAssinaturas { get; set; }
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ControleDeAssinaturasModel>(entity =>
        {
            entity.ToTable("controledeassinaturas");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DataCriacao).HasColumnName("datacriacao");
            entity.Property(e => e.DataPagamento).HasColumnName("datapagamento");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.IdLinkPagamento).HasColumnName("idlinkpagamento");
            entity.Property(e => e.Valor).HasColumnName("valor");
            entity.Property(e => e.IdCliente).HasColumnName("idcliente");
            entity.Property(e => e.IdPagamento).HasColumnName("idpagamento");
            entity.Property(e => e.IdAssinatura).HasColumnName("idassinatura");
            entity.Property(e => e.NumeroFatura).HasColumnName("numerofatura");
            entity.Property(e => e.NomeCliente).HasColumnName("nomecliente");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.Telefone).HasColumnName("telefone");
            entity.Property(e => e.Estado).HasColumnName("estado");
            entity.Property(e => e.Cidade).HasColumnName("cidade");

        });
            

    }


}