using GerenciadorDeOficios.Domain.Interfaces;
using GerenciadorDeOficios.Infra.Data.Context;

namespace GerenciadorDeOficios.Infra.Data.Repositories;

public class UnitOfWork : IUnitOfWork
{
    public IAdvogadoRepository AdvogadoRepository { get; }
    public IEnderecoRepository EnderecoRepository { get; }
    public IEmpresaRepository EmpresaRepository { get; }
    public IOficioRepository OficioRepository { get; }
    public IPessoaRepository PessoaRepository { get; }
    public IRepresentanteRepository RepresentanteRepository { get; }
    private readonly GerenciadorDeOficiosDbContext Context;

    public UnitOfWork(
        IAdvogadoRepository advogadoRepository, IEnderecoRepository enderecoRepository, IEmpresaRepository empresaRepository,
        IOficioRepository oficioRepository, IPessoaRepository pessoaRepository, IRepresentanteRepository representanteRepository, 
        GerenciadorDeOficiosDbContext context)
    {
        AdvogadoRepository = advogadoRepository;
        EnderecoRepository = enderecoRepository;
        EmpresaRepository = empresaRepository;
        OficioRepository = oficioRepository;
        PessoaRepository = pessoaRepository;
        RepresentanteRepository = representanteRepository;
        Context = context;
    }

    public void Dispose()
    {
        Context.Dispose();
    }

    public void Save()
    {
        Context.SaveChanges();
    }

    public async Task<int> SaveAsync()
    {
        return await Context.SaveChangesAsync();
    }
}
