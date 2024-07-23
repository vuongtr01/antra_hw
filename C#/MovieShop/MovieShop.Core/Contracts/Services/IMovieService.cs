using MovieShop.Core.Models.RequestModels;
using MovieShop.Core.Models.ResponseModels;

namespace MovieShop.Core.Contracts.Services;

public interface IMovieService
{
    Task<int> AddMovie(MovieRequestModel model);
    Task<int> UpdateMovie(MovieRequestModel model, int id);
    Task<int> DeleteMovie(int id);
    Task<IEnumerable<MovieResponseModel>> GetAllMovies();
    Task<MovieResponseModel> GetById(int id);
    Task<List<MovieCastResponseModel>> GetCastsList(int id);
}