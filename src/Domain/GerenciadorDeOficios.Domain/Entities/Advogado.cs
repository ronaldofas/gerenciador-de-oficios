namespace GerenciadorDeOficios.Domain.Entities;

public class Advogado : Pessoa
{
    public string NumeroOab { get; set; }
    public Empresa Empresa { get; set; }  // Empresa que ele representa como advogado
    public int EmpresaId { get; set; }

    public Advogado(string numeroOab, Empresa empresa, int empresaId, Pessoa pessoa) : 
        base(pessoa.Id, pessoa.Nome, pessoa.Nacionalidade, pessoa.EstadoCivil, pessoa.Rg, pessoa.Cpf, pessoa.Telefone, pessoa.Email, pessoa.Endereco, pessoa.EnderecoId)
    {
        NumeroOab = numeroOab;
        Empresa = empresa;
        EmpresaId = empresaId;
    }

}