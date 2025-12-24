using StudentAnalytics.App.Models;

namespace StudentAnalytics.App.Services;

public class StudentService
{
    public double CalculateGroupAverage(List<Student> students)
    {
        if (students.Count == 0) return 0;
        return students.Average(s => s.AverageGrade());
    }

    public Student GetBestStudent(List<Student> students)
    {
        return students.OrderByDescending(s => s.AverageGrade()).First();
    }
}
