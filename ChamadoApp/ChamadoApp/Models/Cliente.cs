using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;

namespace ChamadoApp.Models;

public class Cliente
{
    [Key]
    public int Id { get; set; }
    public  string? Nome { get; set; }
    public string? Email { get; set; }
    public string? Telefone { get; set; }

    public ICollection<Chamado> chamados { get; set; } = new List<Chamado>();
}
