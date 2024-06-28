namespace Assignment3.School.Interface;

public interface IStudentService : IPersonService
{
    void EnrollInCourse(Course course);
    double CalculateGPA();
}