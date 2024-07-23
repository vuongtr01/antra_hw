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
    public async Task<IActionResult> Index()
    {
        var movies = await _service.GetAllMovies();
        return View(movies);
    }

    public async Task<IActionResult> Detail(int id)
    {
        var movie = await _service.GetById(id);

        if (movie != null)
        {
            ViewBag.castsList = await _service.GetCastsList(id);
            return View(movie);
        }

        return RedirectToAction("Index");
    }
}