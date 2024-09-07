using GerenciadorDeOficios.Domain.Entities;
using GerenciadorDeOficios.Domain.Interfaces;
using GerenciadorDeOficios.Infra.Data.Context;

namespace GerenciadorDeOficios.Infra.Data.Repositories;

public class OficioRepository : RepositoryBase<Oficio>, IOficioRepository
{
    public OficioRepository(GerenciadorDeOficiosDbContext context) : base(context)
    {
    }
}
