using EntityFramework.Core.Entities;
using EntityFramework.Core.Interfaces.Services;
using EntityFramework.Core.Models.RequestModel;
using EntityFramework.Core.Models.ResponseModel;
using EntityFramework.Infrastructure.Repositories;
using Microsoft.Extensions.Logging;

namespace EntityFramework.Infrastructure.Services;

public class EmployeeService: IEmployeeService
{
    private EmployeeRepository _employeeRepository = new EmployeeRepository();
    public List<EmployeeResponseModel> GetAllEmployees()
    {
        var employees = _employeeRepository.GetAll();
        var employeeResponseModel = new List<EmployeeResponseModel>();

        foreach (var e in employees)
        {
            employeeResponseModel.Add(new EmployeeResponseModel
            {
                EmployeeName = e.EmployeeName,
                Age = e.Age,
            });
        }

        return employeeResponseModel;
    }

    public EmployeeResponseModel GetById(int id)
    {
        var employee = _employeeRepository.GetById(id);
        if (employee != null)
        {
            var employeeResponseModel = new EmployeeResponseModel
            {
                EmployeeName = employee.EmployeeName,
                Age = employee.Age
            };
            return employeeResponseModel;
        }

        return null;
    }

    public int AddEmployee(EmployeeRequestModel model)
    {
        var employeeEntity = new Employee
        {
            EmployeeName = model.EmployeeName,
            Age = model.Age,
            DepartmentId = 1
        }; 
        return _employeeRepository.Insert(employeeEntity);
    }
}