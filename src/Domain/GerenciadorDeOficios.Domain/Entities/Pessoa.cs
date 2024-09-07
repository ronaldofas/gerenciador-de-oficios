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
}