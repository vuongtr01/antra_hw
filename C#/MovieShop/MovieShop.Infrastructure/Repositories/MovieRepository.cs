using Microsoft.EntityFrameworkCore;
using MovieShop.Core.Contracts.Repositories;
using MovieShop.Core.Entities;
using MovieShop.Core.Models.ResponseModels;
using MovieShop.Infrastructure.Data;

namespace MovieShop.Infrastructure.Repositories;

public class MovieRepository: BaseRepository<Movie>, IMovieRepository
{
    public MovieRepository(MovieShopDbContext context): base(context)
    {
    }

    public Movie GetHighestGrossingMovies()
    {
        var highest = _movieShopDbContext.Purchases.GroupBy(p => p.Movie)
            .Select(g => new
            {
                Movie = g.Key,
                TotalPurchase = g.Sum(p => p.TotalPrice)
            })
            .OrderByDescending(m => m.TotalPurchase)
            .FirstOrDefault();

        if (highest != null)
        {
            return highest.Movie;
        }

        return null;
    }

    public List<MovieCastResponseModel> GetCastsList(int id)
    {
        var res = _movieShopDbContext.Movies
            .Include(m => m.MovieCasts)
            .ThenInclude(mc => mc.Cast)
            .FirstOrDefault(m => m.Id == id);
        
        return res?.MovieCasts.Select(mc => new MovieCastResponseModel()
        {
            Id = mc.Cast.Id,
            Name = mc.Cast.Name,
            Character = mc.Character,
            TmdbUrl = mc.Cast.TmdbUrl
        }).ToList();
    }
}