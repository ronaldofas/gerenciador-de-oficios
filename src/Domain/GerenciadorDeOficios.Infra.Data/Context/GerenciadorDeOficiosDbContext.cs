using GerenciadorDeOficios.Domain.Entities;
using GerenciadorDeOficios.Infra.Data.EntityTypeConfigs;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorDeOficios.Infra.Data.Context;

public class GerenciadorDeOficiosDbContext : DbContext
{
    public DbSet<Oficio> Oficios { get; set; }
    public DbSet<Empresa> Empresas { get; set; }
    public DbSet<Endereco> Enderecos { get; set; }
    public DbSet<Representante> Representantes { get; set; }
    public DbSet<Advogado> Advogados { get; set; }

    public GerenciadorDeOficiosDbContext(DbContextOptions<GerenciadorDeOficiosDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Aplicar as configurações separadas
        modelBuilder.ApplyConfiguration(new OficioConfig());
        modelBuilder.ApplyConfiguration(new EmpresaConfig());
        modelBuilder.ApplyConfiguration(new EnderecoConfig());
        modelBuilder.ApplyConfiguration(new RepresentanteConfig());
        modelBuilder.ApplyConfiguration(new AdvogadoConfig());
    }

    // Método para configurar a conexão com SQLite
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlite("Data Source=database.db");
        }
    }
}
