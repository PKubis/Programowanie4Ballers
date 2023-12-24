using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using _4Ballers.Data; 
using System.Linq; 


public class PrivateController : Controller
{
    private readonly ApplicationDbContext _context;

    public PrivateController(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult Shoes()
    {
        ViewData["Title"] = "Obuwie";
        var products = _context.Products.ToList(); // Pobierz produkty z bazy danych
        return View(products); // Przekazuje listę produktów do widoku
    }

    public IActionResult Basket()
    {
        ViewData["Title"] = "Koszyk";
        return View();
    }
}
