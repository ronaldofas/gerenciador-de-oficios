using GerenciadorDeOficios.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciadorDeOficios.Infra.Data.EntityTypeConfigs;

public class EmpresaConfig : IEntityTypeConfiguration<Empresa>
{
    public void Configure(EntityTypeBuilder<Empresa> builder)
    {
        builder.HasKey(e => e.Id); // Chave primária

        builder.Property(e => e.Nome)
            .IsRequired()
            .HasMaxLength(150);

        builder.Property(e => e.Cnpj)
            .IsRequired()
            .HasMaxLength(14);

        builder.Property(e => e.InscricaoEstadual)
            .HasMaxLength(20);

        builder.Property(e => e.Ccm)
            .HasMaxLength(15);

        // Relacionamento 1:1 com Endereço
        builder.HasOne(e => e.Endereco)
            .WithOne(en => en.Empresa)
            .HasForeignKey<Empresa>(e => e.EnderecoId);
    }
}
