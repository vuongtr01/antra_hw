using System.ComponentModel.DataAnnotations;

namespace EntityFramework.Core.Entities;

public class Employee
{
    public int Id { get; set; }
    [MaxLength(50)]
    public string? EmployeeName { set; get; }
    [Required]
    public int Age { get; set; }
    [Required(ErrorMessage= "The department Id field is required")]
    public int DepartmentId { get; set; }
    
    //Navigation
    public Department Department { get; set; }
    
    
}