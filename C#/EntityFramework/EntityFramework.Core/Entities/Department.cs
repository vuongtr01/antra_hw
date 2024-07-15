using System.ComponentModel.DataAnnotations;

namespace EntityFramework.Core.Entities;

public class Department
{
    public int Id { set; get; }
    [MaxLength(50)]
    public string? DepartmentName { get; set; }
    public string? Location { get; set; }
    
    //Navigation
    public List<Employee> Employees { get; set; }
}