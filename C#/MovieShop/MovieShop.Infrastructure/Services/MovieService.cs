using MovieShop.Core.Contracts.Repositories;
using MovieShop.Core.Contracts.Services;
using MovieShop.Core.Entities;
using MovieShop.Core.Models.RequestModels;
using MovieShop.Core.Models.ResponseModels;

namespace MovieShop.Infrastructure.Services;

public class MovieService: IMovieService
{
    private readonly IMovieRepository _movieRepository;

    public MovieService(IMovieRepository movieRepository)
    {
        this._movieRepository = movieRepository;
    }
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

    public int AddMovie(MovieRequestModel model)
    {
        Movie entity = new Movie();
        entity.BackdropUrl = model.BackdropUrl;
        entity.Budget = model.Budget;
        entity.CreateBy = model.CreateBy;
        entity.CreatedDate = model.CreatedDate;
        entity.ImdbUrl = model.ImdbUrl;
        entity.Overview = model.Overview;
        entity.PosterUrl = model.PosterUrl;
        entity.Price = model.Price;
        entity.ReleaseDate = model.ReleaseDate;
        entity.Revenue = model.Revenue;
        entity.RunTime = model.RunTime;
        entity.Title = model.Title;
        entity.TmdbUrl = model.TmdbUrl;

        return this._movieRepository.Insert(entity);
    }

    public int UpdateMovie(MovieRequestModel model, int id)
    {
        Movie entity = new Movie();
        entity.BackdropUrl = model.BackdropUrl;
        entity.Budget = model.Budget;
        entity.CreateBy = model.CreateBy;
        entity.CreatedDate = model.CreatedDate;
        entity.ImdbUrl = model.ImdbUrl;
        entity.Overview = model.Overview;
        entity.PosterUrl = model.PosterUrl;
        entity.Price = model.Price;
        entity.ReleaseDate = model.ReleaseDate;
        entity.Revenue = model.Revenue;
        entity.RunTime = model.RunTime;
        entity.Title = model.Title;
        entity.TmdbUrl = model.TmdbUrl;
        entity.Id = id;

        return _movieRepository.Update(entity);
    }

    public int DeleteMovie(int id)
    {
        return _movieRepository.DeleteById(id);
    }

    public IEnumerable<MovieResponseModel> GetAllMovies()
    {
        var result = _movieRepository.GetAll();
        List < MovieResponseModel > movieResponseModels = new List<MovieResponseModel>();

        foreach (var movie in result)
        {
            MovieResponseModel model = new MovieResponseModel();
            model.Id = movie.Id;
            model.BackdropUrl = model.BackdropUrl;
            model.Budget = model.Budget;
            model.CreateBy = model.CreateBy;
            model.CreatedDate = model.CreatedDate;
            model.ImdbUrl = model.ImdbUrl;
            model.Overview = model.Overview;
            model.PosterUrl = model.PosterUrl;
            model.Price = model.Price;
            model.ReleaseDate = model.ReleaseDate;
            model.Revenue = model.Revenue;
            model.RunTime = model.RunTime;
            model.Title = model.Title;
            model.TmdbUrl = model.TmdbUrl;
            
            movieResponseModels.Add(model);
        }

        return movieResponseModels;
    }

    public MovieResponseModel GetById(int id)
    {
        var result = _movieRepository.GetById(id);

        if (result != null)
        {
            MovieResponseModel model = new MovieResponseModel();
            model.Id = id;
            model.BackdropUrl = model.BackdropUrl;
            model.Budget = model.Budget;
            model.CreateBy = model.CreateBy;
            model.CreatedDate = model.CreatedDate;
            model.ImdbUrl = model.ImdbUrl;
            model.Overview = model.Overview;
            model.PosterUrl = model.PosterUrl;
            model.Price = model.Price;
            model.ReleaseDate = model.ReleaseDate;
            model.Revenue = model.Revenue;
            model.RunTime = model.RunTime;
            model.Title = model.Title;
            model.TmdbUrl = model.TmdbUrl;
        }

        return null;
    }
}