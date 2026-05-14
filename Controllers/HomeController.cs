using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP02.Models;

namespace TP02.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult generarReceta(Receta R)
    {
        ViewBag.tiempo = R.calcularTiempo(R);
        ViewBag.dificultad=R.DeterminarDificultad(R);
        ViewBag.plato=R.DeterminarPlato(R);
        ViewBag.cantPersonas = R.cantPersonas;
        ViewBag.nombreCocinero = R.nombreCocinero;
        ViewBag.edad = R.calcularEdad();
        

        return View("Resultado");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
