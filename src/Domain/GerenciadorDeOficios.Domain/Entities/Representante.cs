namespace GerenciadorDeOficios.Domain.Entities;

public class Representante : Pessoa
{
    public int EmpresaId { get; set; }
    public Empresa Empresa { get; set; }  // Empresa que ele representa

    public Representante(Empresa empresa, int empresaId, Pessoa pessoa) : 
        base(pessoa.Id, pessoa.Nome, pessoa.Nacionalidade, pessoa.EstadoCivil, pessoa.Rg, pessoa.Cpf, pessoa.Telefone, pessoa.Email, pessoa.Endereco, pessoa.EnderecoId)
    {
        Empresa = empresa;
        EmpresaId = empresaId;
    }

}