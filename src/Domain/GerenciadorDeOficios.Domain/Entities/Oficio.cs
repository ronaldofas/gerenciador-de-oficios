namespace GerenciadorDeOficios.Domain.Entities;

public class Oficio
{
    
    public int Id { get; set; }
    public string Forum { get; set; }
    public string NumeroProcesso { get; set; }
    public string VaraProcesso { get; set; }
    public string TipoAcao { get; set; }
    public string TipoProcesso { get; set; }
    public string LocalRedacao { get; set; }
    public DateTime Data { get; set; }

    public Empresa EmpresaSolicitante { get; set; }
    public int EmpresaSolicitanteId { get; set; }

    public Oficio(int id, string forum, string numeroProcesso, string varaProcesso, string tipoAcao, string tipoProcesso, 
        string localRedacao, DateTime data, Empresa empresaSolicitante, int empresaSolicitanteId)
    {
        Id = id;
        Forum = forum;
        NumeroProcesso = numeroProcesso;
        VaraProcesso = varaProcesso;
        TipoAcao = tipoAcao;
        TipoProcesso = tipoProcesso;
        LocalRedacao = localRedacao;
        Data = data;
        EmpresaSolicitante = empresaSolicitante;
        EmpresaSolicitanteId = empresaSolicitanteId;
    }

}