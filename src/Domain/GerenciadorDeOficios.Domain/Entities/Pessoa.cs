namespace GerenciadorDeOficios.Domain.Entities;

public class Pessoa
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Nacionalidade { get; set; }
    public string EstadoCivil { get; set; }
    public string Rg { get; set; }
    public string Cpf { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }

    public Endereco Endereco { get; set; }
    public int EnderecoId { get; set; }

    public Pessoa(int id, string nome, string nacionalidade, string estadoCivil, 
        string rg, string cpf, string telefone, string email, Endereco endereco, int enderecoId)
    {
        Id = id;
        Nome = nome;
        Nacionalidade = nacionalidade;
        EstadoCivil = estadoCivil;
        Rg = rg;
        Cpf = cpf;
        Telefone = telefone;
        Email = email;
        Endereco = endereco;
        EnderecoId = enderecoId;
    }

}