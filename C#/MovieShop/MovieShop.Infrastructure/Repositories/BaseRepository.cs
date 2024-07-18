using MovieShop.Core.Contracts.Repositories;

namespace MovieShop.Infrastructure.Repositories;

public class BaseRepository<T>: IRepository<T> where T: class
{
    
}