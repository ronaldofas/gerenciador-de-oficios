using GerenciadorDeOficios.Domain.Entities;
using GerenciadorDeOficios.Domain.Interfaces;
using GerenciadorDeOficios.Infra.Data.Context;

namespace GerenciadorDeOficios.Infra.Data.Repositories;

public class EmpresaRepository : RepositoryBase<Empresa>, IEmpresaRepository
{
    public EmpresaRepository(GerenciadorDeOficiosDbContext context) : base(context)
    {
    }
}
