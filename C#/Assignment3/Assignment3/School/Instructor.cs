using Assignment3.School.Interface;

namespace Assignment3.School;

public class Instructor : Person, IInstructorService
{
    public Department Department { get; private set; }
    public bool IsHead { get; private set; }
    public DateTime JoinDate { get; set; }

    public Instructor(string name, DateTime dateOfBirth, decimal salary, DateTime joinDate)
        : base(name, dateOfBirth, salary)
    {
        JoinDate = joinDate;
    }

    public void AssignToDepartment(Department department)
    {
        Department = department;
    }

    public void AssignAsHead()
    {
        IsHead = true;
    }

    public override decimal CalculateSalary()
    {
        int yearsOfExperience = DateTime.Now.Year - JoinDate.Year;
        return Salary + (yearsOfExperience * 1000); // Example bonus calculation
    }
}