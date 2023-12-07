// Student.cs
using System;

public class Student
{
    public int StudentId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }

    public void DisplayStudentInfo()
    {
        Console.WriteLine($"Student ID: {StudentId}");
        Console.WriteLine($"Name: {FirstName} {LastName}");
        Console.WriteLine($"Birthdate: {BirthDate.ToShortDateString()}");
    }
}
