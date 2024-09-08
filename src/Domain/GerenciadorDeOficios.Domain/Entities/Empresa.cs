namespace GerenciadorDeOficios.Domain.Entities;

public class Empresa
{
    

    public int Id { get; set; }
    public string Nome { get; set; }
    public string Cnpj { get; set; }
    public string InscricaoEstadual { get; set; }
    public string Ccm { get; set; }

    public Endereco Endereco { get; set; }
    public int EnderecoId { get; set; }
    
    public ICollection<Representante> Representantes { get; set; } = new List<Representante>();
    public ICollection<Advogado> Advogados { get; set; } = new List<Advogado>();

    public Empresa(int id, string nome, string cnpj, string inscricaoEstadual, string ccm, Endereco endereco, int enderecoId)
    {
        Id = id;
        Nome = nome;
        Cnpj = cnpj;
        InscricaoEstadual = inscricaoEstadual;
        Ccm = ccm;
        Endereco = endereco;
        EnderecoId = enderecoId;
    }
}