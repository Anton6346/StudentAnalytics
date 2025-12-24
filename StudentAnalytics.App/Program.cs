using StudentAnalytics.App.Models;
using StudentAnalytics.App.Services;

var students = new List<Student>
{
    new Student("Ivan", new List<int> { 90, 85, 88 }),
    new Student("Maria", new List<int> { 95, 92, 93 }),
    new Student("Oleh", new List<int> { 78, 80, 75 })
};

var service = new StudentService();

Console.WriteLine($"Group average grade: {service.CalculateGroupAverage(students):F2}");

var best = service.GetBestStudent(students);
Console.WriteLine($"Best student: {best.Name} with average {best.AverageGrade():F2}");
