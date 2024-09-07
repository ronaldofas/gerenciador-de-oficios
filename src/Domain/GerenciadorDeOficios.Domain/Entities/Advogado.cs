namespace GerenciadorDeOficios.Domain.Entities;

public class Advogado : Pessoa
{
    public string NumeroOab { get; set; }
    public Empresa Empresa { get; set; }  // Empresa que ele representa como advogado
    public int EmpresaId { get; set; }
}