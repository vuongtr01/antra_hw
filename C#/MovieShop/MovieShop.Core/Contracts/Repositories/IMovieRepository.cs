using MovieShop.Core.Entities;
using MovieShop.Core.Models.ResponseModels;

namespace MovieShop.Core.Contracts.Repositories;

public interface IMovieRepository: IRepository<Movie>
{
    Movie GetHighestGrossingMovies();
    List<MovieCastResponseModel> GetCastsList(int id);

}