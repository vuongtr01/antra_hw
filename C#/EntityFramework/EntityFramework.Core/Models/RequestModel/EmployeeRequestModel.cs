using System.ComponentModel.DataAnnotations;

namespace EntityFramework.Core.Models.RequestModel;

public class EmployeeRequestModel
{
    [Required(ErrorMessage = "Employee name is required")]
    [StringLength(256)]
    public string? EmployeeName { set; get; }
    public int Age { get; set; }
}