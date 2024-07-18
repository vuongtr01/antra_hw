using MovieShop.Core.Models.ResponseModels;

namespace MovieShop.Infrastructure.Services;

public class MovieService
{
    public List<MovieCardResponseModel> getMovies()
    {
        return new List<MovieCardResponseModel>()
        {
            new MovieCardResponseModel()
            {
                Id = 1, ImgUrl = "https://image.tmdb.org/t/p/w342//78lPtwv72eTNqFW9COBYI0dWDJa.jpg", Name = "Movie 1"
            },
            new MovieCardResponseModel()
            {
                Id = 2, ImgUrl = "https://image.tmdb.org/t/p/w342//78lPtwv72eTNqFW9COBYI0dWDJa.jpg", Name = "Movie 2"
            },

        };
    }
}