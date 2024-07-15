using EntityFramework.Core.Entities;
using EntityFramework.Core.Interfaces.Services;
using EntityFramework.Core.Models.RequestModel;
using EntityFramework.Core.Models.ResponseModel;
using EntityFramework.Infrastructure.Repositories;

namespace EntityFramework.Infrastructure.Services;

public class DepartmentService: IDepartmentService
{
    private DepartmenRepository _departmenRepository = new DepartmenRepository();
    public List<DepartmentResponseModel> GetAllDepartments()
    {
        var departments = _departmenRepository.GetAll();
        var departmentResponses = new List<DepartmentResponseModel>();

        foreach (var dep in departments)
        {
            departmentResponses.Add(new DepartmentResponseModel
            {
                DepartmentName = dep.DepartmentName,
                Location = dep.Location
            });
        }

        return departmentResponses;
    }

    public DepartmentResponseModel GetById(int id)
    {
        var department = _departmenRepository.GetById(id);

        if (department != null)
        {
            return new DepartmentResponseModel
            {
                DepartmentName = department.DepartmentName,
                Location = department.Location
            };
        }

        return null;
    }

    public int AddDepartment(DepartmentRequestModel model)
    {
        var departmentEntity = new Department
        {
            DepartmentName = model.DepartmentName,
            Location = model.Location
        };

        return _departmenRepository.Insert(departmentEntity);
    }

    public int DeleteById(int id)
    {
        return _departmenRepository.DeleteById(id);
    }

    public int Update(DepartmentRequestModel model)
    {
        return _departmenRepository.Update(new Department
        {
            Id = model.Id,
            DepartmentName = model.DepartmentName,
            Location = model.Location
        });
    }
}