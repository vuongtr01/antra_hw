using Microsoft.AspNetCore.Mvc;
using MovieShop.Core.Contracts.Services;
using MovieShop.Core.Models.ResponseModels;

namespace MovieShop.MVCApp.Controllers;

public class CastController : Controller
{
    private readonly ICastService _castService;

    // GET
    public CastController(ICastService service)
    {
        this._castService = service;
    }
    public IActionResult Detail(int id)
    {
        CastResponseModel model = _castService.GetById(id);
        var test = model.movies;
        var test2 = 1;
        return View(model);
    }
}