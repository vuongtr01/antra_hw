using Microsoft.AspNetCore.Mvc;
using MovieShop.Core.Contracts.Services;
using MovieShop.Infrastructure.Services;

namespace MovieShop.MVCApp.Controllers;

public class MoviesController : Controller
{
    private readonly IMovieService _service;

    public MoviesController(IMovieService service)
    {
        this._service = service;
    }
    // GET
    public IActionResult Index()
    {
        var movies = _service.GetAllMovies();
        return View(movies);
    }

    public IActionResult Detail(int id)
    {
        var movie = _service.GetById(id);

        if (movie != null)
        {
            return View(movie);
        }

        return RedirectToAction("Index");
    }
}