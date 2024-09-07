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
}