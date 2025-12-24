using StudentAnalytics.App.Models;
using StudentAnalytics.App.Services;
using Xunit;

public class StudentServiceTests
{
    [Fact]
    public void CalculateGroupAverage_ReturnsCorrectValue()
    {
        var students = new List<Student>
        {
            new Student("A", new List<int> { 100, 90 }),
            new Student("B", new List<int> { 80, 70 })
        };

        var service = new StudentService();
        var result = service.CalculateGroupAverage(students);

        Assert.Equal(85, result);
    }

    [Fact]
    public void GetBestStudent_ReturnsStudentWithHighestAverage()
    {
        var students = new List<Student>
        {
            new Student("Low", new List<int> { 60, 65 }),
            new Student("High", new List<int> { 95, 90 })
        };

        var service = new StudentService();
        var best = service.GetBestStudent(students);

        Assert.Equal("High", best.Name);
    }
}
