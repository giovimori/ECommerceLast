using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using basilico.karol._5h.Ecommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace basilico.karol._5h.Ecommerce.Controllers;

public class ProdottiController : Controller
{
    
    private readonly dbContext _context;
  


    public ProdottiController(dbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        
        return View();
    }
}