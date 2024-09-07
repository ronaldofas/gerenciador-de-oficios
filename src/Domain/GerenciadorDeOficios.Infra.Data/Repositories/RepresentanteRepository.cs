using GerenciadorDeOficios.Domain.Entities;
using GerenciadorDeOficios.Domain.Interfaces;
using GerenciadorDeOficios.Infra.Data.Context;

namespace GerenciadorDeOficios.Infra.Data.Repositories;

public class RepresentanteRepository : RepositoryBase<Representante>, IRepresentanteRepository
{
    public RepresentanteRepository(GerenciadorDeOficiosDbContext context) : base(context)
    {
    }
}
