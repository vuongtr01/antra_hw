using MovieShop.Core.Entities;
using MovieShop.Core.Models.ResponseModels;

namespace MovieShop.Core.Contracts.Repositories;

public interface IMovieRepository: IRepositoryAsync<Movie>
{
    Task<Movie> GetHighestGrossingMovies();
    Task<List<MovieCastResponseModel>> GetCastsList(int id);

}