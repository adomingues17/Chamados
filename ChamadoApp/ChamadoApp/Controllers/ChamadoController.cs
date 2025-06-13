using ChamadoApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ChamadoApp.Controllers;

public class ChamadoController : Controller
{
    private readonly AppDbContext _context;
    public ChamadoController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var chamados = _context.Chamados.Include(c => c.Cliente).ToList();
        return View(chamados);
    }

    public IActionResult Create()
    {
        ViewBag.Clientes = _context.Clientes.ToList();
        return View();
    }

}