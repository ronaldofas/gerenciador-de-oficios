using GerenciadorDeOficios.Domain.Entities;
using GerenciadorDeOficios.Domain.Interfaces;
using GerenciadorDeOficios.Infra.Data.Context;

namespace GerenciadorDeOficios.Infra.Data.Repositories;

public class PessoaRepository : RepositoryBase<Pessoa>, IPessoaRepository
{
    public PessoaRepository(GerenciadorDeOficiosDbContext context) : base(context)
    {
    }
}
