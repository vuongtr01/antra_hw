using Microsoft.EntityFrameworkCore;
using MovieShop.Core.Contracts.Repositories;
using MovieShop.Core.Entities;
using MovieShop.Core.Models.ResponseModels;
using MovieShop.Infrastructure.Data;

namespace MovieShop.Infrastructure.Repositories;

public class CastRepository: BaseRepository<Cast>, ICastRepository
{
    public CastRepository(MovieShopDbContext movieShopDbContext) : base(movieShopDbContext)
    {
    }

    public Cast GetCastDetails(int id)
    {
        return _movieShopDbContext.Casts
            .Include(c => c.MovieCasts)
            .ThenInclude(c => c.Movie)
            .FirstOrDefault(c => c.Id == id);
    }
}