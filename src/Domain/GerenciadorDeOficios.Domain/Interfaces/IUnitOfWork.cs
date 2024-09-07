namespace GerenciadorDeOficios.Domain.Interfaces;

public interface IUnitOfWork : IDisposable
{
    IAdvogadoRepository AdvogadoRepository { get; }
    IEnderecoRepository EnderecoRepository { get; }
    IEmpresaRepository EmpresaRepository { get; }
    IOficioRepository OficioRepository { get; }
    IPessoaRepository PessoaRepository { get; }
    IRepresentanteRepository RepresentanteRepository { get; }
    void Save();
    Task<int> SaveAsync();
}
