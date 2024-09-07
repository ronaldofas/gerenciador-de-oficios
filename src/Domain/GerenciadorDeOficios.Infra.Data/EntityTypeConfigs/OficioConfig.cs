using GerenciadorDeOficios.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciadorDeOficios.Infra.Data.EntityTypeConfigs;

public class OficioConfig : IEntityTypeConfiguration<Oficio>
{
    public void Configure(EntityTypeBuilder<Oficio> builder)
    {
        builder.HasKey(o => o.Id); // Chave primária

        builder.Property(o => o.Forum)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(o => o.NumeroProcesso)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(o => o.VaraProcesso)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(o => o.TipoAcao)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(o => o.TipoProcesso)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(o => o.LocalRedacao)
            .IsRequired()
            .HasMaxLength(100);

        builder.HasOne(o => o.EmpresaSolicitante)
            .WithMany()
            .HasForeignKey(o => o.EmpresaSolicitanteId);
    }
}
