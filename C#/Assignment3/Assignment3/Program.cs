// See https://aka.ms/new-console-template for more information
using Assignment3;
using Assignment3.School;
using Assignment3.Color;
// ReverseArray.Run();
// Fibonanci.PrintFibo();

// Instructor instructor = new Instructor("John Doe", new DateTime(1980, 5, 20), 50000, new DateTime(2010, 9, 1));
// Student student = new Student("Jane Smith", new DateTime(2000, 8, 15), 0);
// Department department = new Department("Computer Science", 1000000, new DateTime(2023, 9, 1), new DateTime(2024, 5, 31));
// Course course = new Course("Introduction to Programming");
//
// department.SetHead(instructor);
// instructor.AssignToDepartment(department);
//
// student.EnrollInCourse(course);
//
// course.AssignGrade(student, 'A');
//
// Console.WriteLine($"Instructor: {instructor.Name}, Age: {instructor.CalculateAge()}, Salary: {instructor.CalculateSalary()}");
// Console.WriteLine($"Student: {student.Name}, Age: {student.CalculateAge()}, GPA: {student.CalculateGPA()}");
// Console.WriteLine($"Department: {department.DepartmentName}, Head: {department.Head.Name}");
// Console.WriteLine($"Course: {course.CourseName}, Enrolled Students: {course.GetEnrolledStudents().Count}");

Color redColor = new Color(255, 0, 0);
Color blueColor = new Color(0, 0, 255);

Ball ball1 = new Ball(10, redColor);
Ball ball2 = new Ball(15, blueColor);

ball1.Throw();
ball1.Throw();
ball2.Throw();

ball1.Pop();
ball1.Throw();

Console.WriteLine($"Ball 1 throw count: {ball1.GetThrowCount()}");
Console.WriteLine($"Ball 2 throw count: {ball2.GetThrowCount()}");

Console.WriteLine($"Red color grayscale value: {redColor.GetGrayscale()}");
Console.WriteLine($"Blue color grayscale value: {blueColor.GetGrayscale()}");