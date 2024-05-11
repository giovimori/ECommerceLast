using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using basilico.karol._5h.Ecommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace basilico.karol._5h.Ecommerce.Controllers;

public class HomeController : Controller
{
    
    private readonly ILogger<HomeController> _logger;
    private static List<Utente> Utenti = new List<Utente>();


    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        string? login = HttpContext.Session.GetString("login");
        if(login == "giovanni")
        {
            return View("Privacy");
        }
        return View();
    }
    public IActionResult Controllo()
    {
        return View();
    }
    public IActionResult Profilo()
    {
        return View("Profilo");
    }
    public IActionResult Privacy()
    {
        return View();
    }

     public IActionResult Registrazione()
    {
        return View();
    }

    public IActionResult Login()
    {
        return View();
    }

     public IActionResult Logout()
    {
        return View();
    }

    public IActionResult Farmaci()
    {
        return View();
    }
    public IActionResult Aiuto()
    {
        return View();
    }

    public IActionResult Carrello()
    {
        return View();
    }
    public IActionResult Database()
    {
        string? Nome = HttpContext.Session.GetString("Nome");
        if (string.IsNullOrEmpty(Nome))
            return Redirect("\\home\\index");
        dbContext db = new ();
        db.SaveChanges();
        return View(db);       
    }

    [HttpPost]
    public IActionResult p1(Utente u)
    {
        dbContext db = new();
        if(u.EMail != null)
        {
            HttpContext.Session.SetString("login", u.EMail);
        }
        string? login = HttpContext.Session.GetString("login");
        foreach(var item in db.Utenti)
        {
            if(u.EMail==item.EMail && u.Password==item.Password)
            {
                
                return RedirectToAction("Index");
            }
           
        }
        return View("Registrazione");
    }

    [HttpPost]
    public IActionResult p2()   //logout
    {
        HttpContext.Session.SetString("login", "-");
        return View("Index");
    }

    [HttpPost]
    public IActionResult Registrato( Utente u )
    {

        dbContext db = new ();
        db.Utenti.Add(u);
        db.SaveChanges();
        //settiamo una variabile di sessione chiamata nomeutente con valore u.Nome
        // HttpContext.Session.SetString("NomeUtente", u.Nome );
        return View(db);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
