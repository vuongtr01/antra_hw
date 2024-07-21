using MovieShop.Core.Contracts.Repositories;
using MovieShop.Core.Entities;
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
}