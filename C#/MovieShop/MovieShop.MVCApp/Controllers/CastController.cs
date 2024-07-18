using Microsoft.AspNetCore.Mvc;

namespace MovieShop.MVCApp.Controllers;

public class CastController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}