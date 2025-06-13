using System.ComponentModel.DataAnnotations;

namespace ChamadoApp.Models;

public class Chamado
{
    
    public  int Id { get; set; }
    public string Titulo { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public DateTime DataAbertura { get; set; } = DateTime.Now;
    public string Status { get; set; } = "Aberto";
    public int ClienteId { get; set; }
    public Cliente? Cliente { get; set; }
}
