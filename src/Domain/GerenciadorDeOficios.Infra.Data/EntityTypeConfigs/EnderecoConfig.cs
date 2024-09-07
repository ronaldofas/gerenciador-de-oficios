using GerenciadorDeOficios.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciadorDeOficios.Infra.Data.EntityTypeConfigs;

public class EnderecoConfig : IEntityTypeConfiguration<Endereco>
{
    public void Configure(EntityTypeBuilder<Endereco> builder)
    {
        builder.HasKey(en => en.Id); // Chave primária

        builder.Property(en => en.TipoEndereco)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(en => en.NomeEndereco)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(en => en.Numero)
            .IsRequired()
            .HasMaxLength(10);

        builder.Property(en => en.Complemento)
            .HasMaxLength(100);

        builder.Property(en => en.Bairro)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(en => en.Cidade)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(en => en.Estado)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(en => en.Uf)
            .IsRequired()
            .HasMaxLength(2);

        builder.Property(en => en.Cep)
            .IsRequired()
            .HasMaxLength(10);
    }
}
