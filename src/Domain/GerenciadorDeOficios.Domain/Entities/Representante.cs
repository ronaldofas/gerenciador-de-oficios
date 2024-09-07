namespace GerenciadorDeOficios.Domain.Entities;

public class Representante : Pessoa
{
    public Empresa Empresa { get; set; }  // Empresa que ele representa
    public int EmpresaId { get; set; }
}