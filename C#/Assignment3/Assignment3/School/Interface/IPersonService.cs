namespace Assignment3.School.Interface;

public interface IPersonService
{
    int CalculateAge();
    decimal CalculateSalary();
    List<string> GetAddresses();
}