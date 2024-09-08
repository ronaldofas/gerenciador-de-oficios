using GerenciadorDeOficios.Domain.Interfaces;
using GerenciadorDeOficios.Infra.Data.Context;
using GerenciadorDeOficios.Infra.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GerenciadorDeOficios.Infra.IoC.DependencyInjection;

public static class DependencyInjectionResolver
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        // Registrar DBContext
        services.AddDbContext<GerenciadorDeOficiosDbContext>(options =>
            options.UseSqlite(configuration.GetConnectionString("DefaultConnection")));
        
        // Registrar Repositorios
        services.AddScoped<IAdvogadoRepository, AdvogadoRepository>();
        services.AddScoped<IEmpresaRepository, EmpresaRepository>();
        services.AddScoped<IEnderecoRepository, EnderecoRepository>();
        services.AddScoped<IOficioRepository, OficioRepository>();
        services.AddScoped<IPessoaRepository, PessoaRepository>();
        services.AddScoped<IRepresentanteRepository, RepresentanteRepository>();

        // Registrar Servicos
        // TODO: Implementar services

        // Registrar UnitOfWork
        services.AddScoped<UnitOfWork>();

        return services;
    }
}
