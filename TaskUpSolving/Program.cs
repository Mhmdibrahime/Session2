namespace TaskUpSolving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>
            {
                 new Student { Name = "Alice", Score = 78 },
                 new Student { Name = "Bob", Score = 45 },
                 new Student { Name = "Charlie", Score = 92 }                                                   
            };

            var scoreProcessor = new ScoreProcessor();

           

            var passedStudents = scoreProcessor.FilterStudents(students, x => x.Score > 60);
            var failedStudents = scoreProcessor.FilterStudents(students, x => x.Score < 60);

            passedStudents.Print();
            Console.WriteLine("--------------------------");
            failedStudents.Print();
            Console.WriteLine("--------------------------");

            var topScorer = students.TopScorer();
            Console.WriteLine(topScorer.Name);
            Console.WriteLine("--------------------------");
            var avg = scoreProcessor.CalcAverage(students,list=>list.Average(x=>x.Score));
            Console.WriteLine(avg);
        }

        static bool MoreThan60Points(Student student)
        {
            return student.Score > 60;
        }
    }
}
