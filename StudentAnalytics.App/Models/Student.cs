namespace StudentAnalytics.App.Models;

public class Student
{
    public string Name { get; set; }
    public List<int> Grades { get; set; }

    public Student(string name, List<int> grades)
    {
        Name = name;
        Grades = grades;
    }

    public double AverageGrade()
    {
        return Grades.Count == 0 ? 0 : Grades.Average();
    }
}
