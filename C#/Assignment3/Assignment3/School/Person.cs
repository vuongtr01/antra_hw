using Assignment3.School.Interface;

namespace Assignment3.School;

public abstract class Person : IPersonService
{
    private List<string> addresses = new List<string>();

    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public decimal Salary { get; private set; }
    
    public Person(string name, DateTime dateOfBirth, decimal salary)
    {
        Name = name;
        DateOfBirth = dateOfBirth;
        Salary = salary >= 0 ? salary : throw new ArgumentException("Salary cannot be negative");
    }

    public int CalculateAge()
    {
        return DateTime.Now.Year - DateOfBirth.Year;
    }

    public abstract decimal CalculateSalary();

    public void AddAddress(string address)
    {
        addresses.Add(address);
    }

    public List<string> GetAddresses()
    {
        return new List<string>(addresses);
    }
}