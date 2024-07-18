using Microsoft.AspNetCore.Mvc;
using MovieShop.Infrastructure.Services;

namespace MovieShop.MVCApp.Controllers;

public class MoviesController : Controller
{
    private readonly MovieService _service;

    public MoviesController(MovieService service)
    {
        this._service = service;
    }
    // GET
    public IActionResult Index()
    {
        var movies = _service.getMovies();
        return View(movies);
    }
}