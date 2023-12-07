// Program.cs
using System;

class Program
{
    static void Main()
    {
        Student student1 = new Student
        {
            StudentId = 1,
            FirstName = "John",
            LastName = "Doe",
            BirthDate = new DateTime(2000, 5, 15)
        };

        Student student2 = new Student
        {
            StudentId = 2,
            FirstName = "Jane",
            LastName = "Smith",
            BirthDate = new DateTime(1999, 8, 22)
        };

        Course course = new Course
        {
            CourseId = 101,
            CourseName = "Computer Science 101"
        };

        course.EnrolledStudents.Add(student1);
        course.EnrolledStudents.Add(student2);

        Console.WriteLine("Course Information:");
        course.DisplayCourseInfo();
    }
}
