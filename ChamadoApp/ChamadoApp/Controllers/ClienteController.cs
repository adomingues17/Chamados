using ChamadoApp.Data;
using ChamadoApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace ChamadoApp.Controllers;

public class ClienteController : Controller
{
    private readonly AppDbContext _context;
    public ClienteController(AppDbContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        var clientes = _context.Clientes.ToList();
        return View(clientes);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Cliente cliente)
    {
        if (ModelState.IsValid)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(cliente);
    }

    public IActionResult Edit(int? id)
    {
        if (id == null || id == 0)
        {
            return NotFound();
        }
        Cliente clienteFromDb = _context.Clientes.Find(id);
        if (clienteFromDb == null)
        {
            return NotFound();
        }
        return View(clienteFromDb);        
    }
    [HttpPost]
    public IActionResult Edit(Cliente obj)
    {
            if (ModelState.IsValid)
            {
                _context.Clientes.Update(obj);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
    }
    public IActionResult Delete(int? id)
    {
        if(id == null || id == 0)
        {
            return NotFound();
        }
        Cliente clienteFromDb = _context.Clientes.Find(id);
        if(clienteFromDb == null)
        {
            return NotFound();
        }
        return View(clienteFromDb);
    }
    [HttpPost]
    public IActionResult Delete(int id)
    {
        Cliente obj = _context.Clientes.Find(id);
        if(obj == null)
        {
            return NotFound();
        }
        _context.Clientes.Remove(obj);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

}
