using Assignment3.School.Interface;

namespace Assignment3.School;

public class Course : ICourseService
{
    public string CourseName { get; set; }
    private Dictionary<Student, char> enrolledStudents = new Dictionary<Student, char>();

    public Course(string courseName)
    {
        CourseName = courseName;
    }

    public void EnrollStudent(Student student)
    {
        if (!enrolledStudents.ContainsKey(student))
        {
            enrolledStudents.Add(student, 'A');
        }
    }

    public void AssignGrade(Student student, char grade)
    {
        if (enrolledStudents.ContainsKey(student))
        {
            enrolledStudents[student] = grade;
        }
    }

    public List<Student> GetEnrolledStudents()
    {
        return new List<Student>(enrolledStudents.Keys);
    }

    public double GetGradePoint(Student student)
    {
        if (enrolledStudents.TryGetValue(student, out char grade))
        {
            switch (grade)
            {
                case 'A': return 4.0;
                case 'B': return 3.0;
                case 'C': return 2.0;
                case 'D': return 1.0;
                case 'F': return 0.0;
                default: return 0.0;
            }
        }
        return 0.0;
    }
}