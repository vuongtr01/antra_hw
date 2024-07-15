using EntityFramework.Core.Entities;
using EntityFramework.Core.Interfaces.Repositories;

namespace EntityFramework.Infrastructure.Repositories;

public class DepartmenRepository: BaseRepository<Department>, IDepartmentRepository
{
    
}