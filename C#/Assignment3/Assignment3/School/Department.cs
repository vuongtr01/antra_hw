using Assignment3.School.Interface;

namespace Assignment3.School;

public class Department : IDepartmentService
{
    public string DepartmentName { get; set; }
    public Instructor Head { get; private set; }
    public decimal Budget { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    private List<Course> courses = new List<Course>();

    public Department(string departmentName, decimal budget, DateTime startDate, DateTime endDate)
    {
        DepartmentName = departmentName;
        Budget = budget;
        StartDate = startDate;
        EndDate = endDate;
    }

    public void SetHead(Instructor instructor)
    {
        Head = instructor;
        instructor.AssignAsHead();
    }

    public void AddCourse(Course course)
    {
        courses.Add(course);
    }

    public List<Course> GetCourses()
    {
        return new List<Course>(courses);
    }
}