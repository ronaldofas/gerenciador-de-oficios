using GerenciadorDeOficios.Domain.Entities;
using GerenciadorDeOficios.Domain.Interfaces;
using GerenciadorDeOficios.Infra.Data.Context;

namespace GerenciadorDeOficios.Infra.Data.Repositories;

public class EnderecoRepository : RepositoryBase<Endereco>, IEnderecoRepository
{
    public EnderecoRepository(GerenciadorDeOficiosDbContext context) : base(context)
    {
    }
}
