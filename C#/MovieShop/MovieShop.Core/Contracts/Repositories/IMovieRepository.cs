using MovieShop.Core.Entities;

namespace MovieShop.Core.Contracts.Repositories;

public interface IMovieRepository: IRepository<Movie>
{
    Movie GetHighestGrossingMovies();
    
}