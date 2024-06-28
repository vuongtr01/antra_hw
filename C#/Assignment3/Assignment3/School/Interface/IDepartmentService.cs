namespace Assignment3.School.Interface;

public interface IDepartmentService
{
    void SetHead(Instructor instructor);
    List<Course> GetCourses();
}