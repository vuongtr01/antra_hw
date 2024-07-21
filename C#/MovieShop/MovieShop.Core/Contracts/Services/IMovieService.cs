using MovieShop.Core.Models.RequestModels;
using MovieShop.Core.Models.ResponseModels;

namespace MovieShop.Core.Contracts.Services;

public interface IMovieService
{
    int AddMovie(MovieRequestModel model);
    int UpdateMovie(MovieRequestModel model, int id);
    int DeleteMovie(int id);
    IEnumerable<MovieResponseModel> GetAllMovies();
    MovieResponseModel GetById(int id);
}