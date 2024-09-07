using GerenciadorDeOficios.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciadorDeOficios.Infra.Data.EntityTypeConfigs;

public class PessoaConfiguration : IEntityTypeConfiguration<Pessoa>
{
    public void Configure(EntityTypeBuilder<Pessoa> builder)
    {
        builder.HasKey(p => p.Id); // Chave primária

        builder.Property(p => p.Nome)
            .IsRequired()
            .HasMaxLength(150);

        builder.Property(p => p.Nacionalidade)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(p => p.EstadoCivil)
            .IsRequired()
            .HasMaxLength(20);

        builder.Property(p => p.Rg)
            .IsRequired()
            .HasMaxLength(12);

        builder.Property(p => p.Cpf)
            .IsRequired()
            .HasMaxLength(11);

        builder.Property(p => p.Telefone)
            .HasMaxLength(15);

        builder.Property(p => p.Email)
            .IsRequired()
            .HasMaxLength(100);

        // Relacionamento 1:1 com Endereço
        builder.HasOne(p => p.Endereco)
            .WithOne(e => e.Pessoa)
            .HasForeignKey<Pessoa>(p => p.EnderecoId);
    }
}
