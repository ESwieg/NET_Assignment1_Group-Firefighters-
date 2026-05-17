public class Student
{
    public string StudentID { get; set; }
    public string FullName { get; set; }
    public string Course { get; set; }
    public double AttendanceRate { get; set; }

    public string GetAcademicStatus()
    {
        if (AttendanceRate < 80)
        {
            return "At Risk";
        }
        else
        {
            return "Good Standing";
        }
    }

    public void DisplayDetails()
    {
        Console.WriteLine("================================");
        Console.WriteLine($"Student ID     : {StudentID}");
        Console.WriteLine($"Full Name      : {FullName}");
        Console.WriteLine($"Course         : {Course}");
        Console.WriteLine($"Attendance     : {AttendanceRate}%");
        Console.WriteLine($"Academic Status: {GetAcademicStatus()}");
        Console.WriteLine("================================");
    }
}
