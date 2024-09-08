namespace GerenciadorDeOficios.Domain.Entities;

public class Endereco
{
    public int Id { get; set; }
    public string TipoEndereco { get; set; }
    public string NomeEndereco { get; set; }
    public string Numero { get; set; }
    public string Complemento { get; set; }
    public string Bairro { get; set; }
    public string Cidade { get; set; }
    public string Estado { get; set; }
    public string Uf { get; set; }
    public string Cep { get; set; }

    public Empresa Empresa { get; set; }  // Relacionamento 1:1 com Empresa
    public Pessoa Pessoa { get; set; }  // Relacionamento 1:1 com Pessoa

    public Endereco(int id, string tipoEndereco, string nomeEndereco, string numero, string complemento, string bairro, 
        string cidade, string estado, string uf, string cep, Empresa empresa, Pessoa pessoa)
    {
        Id = id;
        TipoEndereco = tipoEndereco;
        NomeEndereco = nomeEndereco;
        Numero = numero;
        Complemento = complemento;
        Bairro = bairro;
        Cidade = cidade;
        Estado = estado;
        Uf = uf;
        Cep = cep;
        Empresa = empresa;
        Pessoa = pessoa;
    }


}