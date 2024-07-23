using MovieShop.Core.Entities;

namespace MovieShop.Core.Contracts.Repositories;

public interface ICastRepository: IRepository<Cast>
{
    Cast GetCastDetails(int id);
}