using GerenciadorDeOficios.Domain.Entities;
using GerenciadorDeOficios.Domain.Interfaces;
using GerenciadorDeOficios.Infra.Data.Context;

namespace GerenciadorDeOficios.Infra.Data.Repositories;

public class AdvogadoRepository : RepositoryBase<Advogado>, IAdvogadoRepository
{
    public AdvogadoRepository(GerenciadorDeOficiosDbContext context) : base(context)
    {
    }
}
