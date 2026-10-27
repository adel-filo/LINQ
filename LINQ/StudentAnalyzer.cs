public class StudentAnalyzer
{
    private readonly List<Student> _students;

    public StudentAnalyzer(List<Student> students)
    {
        _students = students;
    }

    public void ExecuteAllQueries()
    {
        var olderThan20 = _students.Where(s => s.Age > 20);
        Console.WriteLine("Students older than 20:");
        foreach (var s in olderThan20) Console.WriteLine($"- {s.Name} ({s.Age})");

        var moreThan80Points = _students.Where(s => s.Points > 80);
        Console.WriteLine("\nStudents with more than 80 points:");
        foreach (var s in moreThan80Points) Console.WriteLine($"- {s.Name} ({s.Points}p)");

        var namesOnly = _students.Select(s => s.Name);
        Console.WriteLine($"\nNames only: {string.Join(", ", namesOnly)}");

        var nameAndPoints = _students.Select(s => new { s.Name, s.Points });
        Console.WriteLine("\nName and points (anonymous type):");
        foreach (var item in nameAndPoints) Console.WriteLine($"- {item.Name}: {item.Points}p");

        var sortedByAge = _students.OrderBy(s => s.Age);
        Console.WriteLine("\nSorted by age:");
        foreach (var s in sortedByAge) Console.WriteLine($"- {s.Name} ({s.Age})");

        var sortedByPoints = _students.OrderByDescending(s => s.Points);
        Console.WriteLine("\nSorted by points (highest first):");
        foreach (var s in sortedByPoints) Console.WriteLine($"- {s.Name} ({s.Points}p)");

        int totalCount = _students.Count();
        Console.WriteLine($"\nTotal number of students: {totalCount}");

        int classACount = _students.Count(s => s.ClassName == "A");
        Console.WriteLine($"Students in class A: {classACount}");

        var firstThree = _students.Take(3);
        Console.WriteLine("\nFirst three students:");
        foreach (var s in firstThree) Console.WriteLine($"- {s.Name}");

        var topTwoScores = _students.OrderByDescending(s => s.Points).Take(2);
        Console.WriteLine("\nTop two scores:");
        foreach (var s in topTwoScores) Console.WriteLine($"- {s.Name} ({s.Points}p)");

        var uniqueClasses = _students.Select(s => s.ClassName).Distinct();
        Console.WriteLine($"\nUnique classes: {string.Join(", ", uniqueClasses)}");

        var uniqueAges = _students.Select(s => s.Age).Distinct();
        Console.WriteLine($"Unique ages: {string.Join(", ", uniqueAges)}");

        bool has100Points = _students.Any(s => s.Points == 100);
        Console.WriteLine($"\nAny student with 100 points? {has100Points}");

        bool allMin50Points = _students.All(s => s.Points >= 50);
        Console.WriteLine($"All students have at least 50 points? {allMin50Points}");

        var firstClassB = _students.FirstOrDefault(s => s.ClassName == "B");
        Console.WriteLine($"\nFirst student in class B: {firstClassB?.Name}");

        var lastStudent = _students.Last();
        Console.WriteLine($"Last student: {lastStudent.Name}");

        var studentById = _students.SingleOrDefault(s => s.Id == 4);
        Console.WriteLine($"Student with ID 4: {studentById?.Name}");

        Console.WriteLine("\nGrouped by class:");
        var groupedByClass = _students.GroupBy(s => s.ClassName);
        foreach (var group in groupedByClass)
        {
            Console.WriteLine($"Class {group.Key}: {string.Join(", ", group.Select(s => s.Name))}");
        }

        int totalPoints = _students.Sum(s => s.Points);
        Console.WriteLine($"\nTotal points: {totalPoints}");

        double averagePoints = _students.Average(s => s.Points);
        Console.WriteLine($"Average points: {averagePoints:F2}");

        int lowestPoints = _students.Min(s => s.Points);
        int highestPoints = _students.Max(s => s.Points);
        Console.WriteLine($"Lowest points: {lowestPoints}, Highest points: {highestPoints}");
    }
}