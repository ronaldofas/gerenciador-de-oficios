using GerenciadorDeOficios.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciadorDeOficios.Infra.Data.EntityTypeConfigs;

public class AdvogadoConfig : IEntityTypeConfiguration<Advogado>
{
    public void Configure(EntityTypeBuilder<Advogado> builder)
    {
        // Configurar a herança de Pessoa
        builder.HasBaseType<Pessoa>();

        // Campo adicional específico para Advogado
        builder.Property(a => a.NumeroOab)
            .IsRequired()
            .HasMaxLength(15);

        // Relacionamento com Empresa (1:N)
        builder.HasOne(a => a.Empresa)
            .WithMany(e => e.Advogados)
            .HasForeignKey(a => a.EmpresaId);
    }
}
