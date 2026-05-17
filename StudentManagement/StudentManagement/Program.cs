// Reviewed and tested by Vito Visagie
// Assignment 2 - Advanced Programming in .NET
// Group: Firefighters | Due: 26 May 2026

Console.WriteLine("==========================================");
Console.WriteLine("  INTERNATIONAL TRAINING COLLEGE - LINGUA");
Console.WriteLine("  Advanced Programming in .NET");
Console.WriteLine("  Assignment 2 - Student Management System");
Console.WriteLine("  Group: Firefighters");
Console.WriteLine("  Hendrina Swiegers (ITCLIT230330)");
Console.WriteLine("  Vito Visagie (ITCLIT220579)");
Console.WriteLine("==========================================");
Console.WriteLine();
Console.WriteLine("PRUDENCE COLLEGE - Student Management System");
Console.WriteLine();

Student student1 = new Student
{
    StudentID = "STU001",
    FullName = "Amara Nakale",
    Course = "Bachelor of IT - Software Development",
    AttendanceRate = 85.5
};

Student student2 = new Student
{
    StudentID = "STU002",
    FullName = "John Smith",
    Course = "Bachelor of IT - Software Development",
    AttendanceRate = 72.0
};

student1.DisplayDetails();
Console.WriteLine();
student2.DisplayDetails();