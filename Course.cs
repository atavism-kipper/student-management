// Course.cs
using System;
using System.Collections.Generic;

public class Course
{
    public int CourseId { get; set; }
    public string CourseName { get; set; }
    public List<Student> EnrolledStudents { get; set; }

    public Course()
    {
        EnrolledStudents = new List<Student>();
    }

    public void DisplayCourseInfo()
    {
        Console.WriteLine($"Course ID: {CourseId}");
        Console.WriteLine($"Course Name: {CourseName}");
        Console.WriteLine("Enrolled Students:");
        foreach (var student in EnrolledStudents)
        {
            student.DisplayStudentInfo();
            Console.WriteLine("---------------------");
        }
    }
}
