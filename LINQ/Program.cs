namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student { Id = 1, Name = "Anna", Age = 19, ClassName = "A", Points = 85 },
                new Student { Id = 2, Name = "Bertil", Age = 22, ClassName = "B", Points = 72 },
                new Student { Id = 3, Name = "Cecilia", Age = 20, ClassName = "A", Points = 91 },
                new Student { Id = 4, Name = "David", Age = 24, ClassName = "C", Points = 64 },
                new Student { Id = 5, Name = "Eva", Age = 19, ClassName = "B", Points = 85 },
                new Student { Id = 6, Name = "Felix", Age = 21, ClassName = "A", Points = 77 },
                new Student { Id = 7, Name = "Gustav", Age = 23, ClassName = "C", Points = 58 },
                new Student { Id = 8, Name = "Hanna", Age = 20, ClassName = "B", Points = 90 }
            };

            StudentAnalyzer analyzer = new StudentAnalyzer(students);
            analyzer.ExecuteAllQueries();
        }
    }
}