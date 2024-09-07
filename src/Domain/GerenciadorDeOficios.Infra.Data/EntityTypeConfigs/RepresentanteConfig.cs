using GerenciadorDeOficios.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciadorDeOficios.Infra.Data.EntityTypeConfigs;

public class RepresentanteConfig : IEntityTypeConfiguration<Representante>
{
    public void Configure(EntityTypeBuilder<Representante> builder)
    {
        // Configurar a herança de Pessoa
        builder.HasBaseType<Pessoa>();

        // Relacionamento com Empresa (1:N)
        builder.HasOne(r => r.Empresa)
            .WithMany(e => e.Representantes)
            .HasForeignKey(r => r.EmpresaId);
    }
}
