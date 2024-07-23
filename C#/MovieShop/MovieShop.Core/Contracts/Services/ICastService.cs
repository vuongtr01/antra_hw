using MovieShop.Core.Models.ResponseModels;

namespace MovieShop.Core.Contracts.Services;

public interface ICastService
{
    CastResponseModel GetById(int id);
}