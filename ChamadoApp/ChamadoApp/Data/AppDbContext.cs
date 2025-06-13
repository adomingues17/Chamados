using Microsoft.EntityFrameworkCore;

namespace ChamadoApp.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    public DbSet<Models.Chamado> Chamados { get; set; }
    public DbSet<Models.Cliente> Clientes { get; set; }


}
