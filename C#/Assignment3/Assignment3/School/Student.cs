using Assignment3.School.Interface;

namespace Assignment3.School;

public class Student : Person, IStudentService
{
    private List<Course> courses = new List<Course>();

    public Student(string name, DateTime dateOfBirth, decimal salary)
        : base(name, dateOfBirth, salary) { }

    public override decimal CalculateSalary()
    {
        return Salary;
    }

    public void EnrollInCourse(Course course)
    {
        courses.Add(course);
        course.EnrollStudent(this);
    }

    public double CalculateGPA()
    {
        if (courses.Count == 0) return 0;

        double totalPoints = courses.Sum(c => c.GetGradePoint(this));
        return totalPoints / courses.Count;
    }
}