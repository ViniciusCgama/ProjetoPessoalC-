using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProjetoPessoal.Models;

namespace RpgMvc.Controllers;

public class HomeController : Controller //: herança
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index() //isso é um get
    {
        return View();// se o view estiver vazio ele vai chamar a pagina citada acima, nesse caso ele chamará a pg Index 
    }

    public IActionResult Privacy()
    {
        return View();
    }
}
