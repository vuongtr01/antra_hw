using EntityFramework.Core.Entities;
using EntityFramework.Core.Models.RequestModel;
using EntityFramework.Core.Models.ResponseModel;
using EntityFramework.Infrastructure.Repositories;
using EntityFramework.Infrastructure.Services;

namespace EntityFramework.Presentation.UI;

public class ManageDepartment
{
    private DepartmentService _departmentService = new DepartmentService();
    
    private void AddDepartment()
    {
        DepartmentRequestModel department = new DepartmentRequestModel();
        Console.WriteLine("Enter Name =>");
        department.DepartmentName = Console.ReadLine();
        Console.WriteLine("Enter Location =>");
        department.Location = Console.ReadLine();

        _departmentService.AddDepartment(department);
    }

    private void DeleteDepartment()
    {
        Console.WriteLine("Enter Id =>");
        int id = Convert.ToInt32(Console.ReadLine());
        _departmentService.DeleteById(id);
    }

    private void UpdateDepartment()
    {
        DepartmentRequestModel department = new DepartmentRequestModel();
        Console.WriteLine("Enter Id =>");
        department.Id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Name =>");
        department.DepartmentName = Console.ReadLine();
        Console.WriteLine("Enter Location =>");
        department.Location = Console.ReadLine();
        _departmentService.Update(department);
    }

    private void PrintAll()
    {
        IEnumerable<DepartmentResponseModel> departments = _departmentService.GetAllDepartments();
        foreach (var department in departments)
        {
            Console.WriteLine(department.Id + "\t" + department.DepartmentName + "\t" + department.Location);
        }
    }

    private void PrintById()
    {
        Console.WriteLine("Enter Id =>");
        int id = Convert.ToInt32(Console.ReadLine());
        var department = _departmentService.GetById(id);
        Console.WriteLine(department.Id + "\t" + department.DepartmentName + "\t" + department.Location);
    }

    public void Run()
    {
        AddDepartment();
        PrintAll();
    }
}