using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
//**Where**
//** Select**
//**OrderBy** / **OrderByDescending**
//** GroupBy**
//**Join**
//** SelectMany**
//**Any**
//** All**
//**FirstOrDefault**
//** SingleOrDefault**
//**Take**
//** Skip**
//**Distinct**
//** Count**
//**Sum**
//** Average**
//**Contains**
//** ToList** / **ToArray**
//** Min** / **Max**
//** Average**
            var students = new List<Student>
{
    new Student { Id = 1, Name = "Alice", Age = 20, GPA = 3.5, Courses = new List<string> { "Math", "Physics" } },
    new Student { Id = 2, Name = "Bob", Age = 22, GPA = 3.8, Courses = new List<string> { "History", "Math" } },
    new Student { Id = 3, Name = "Charlie", Age = 19, GPA = 3.2, Courses = new List<string> { "Physics", "Chemistry" } },
    new Student { Id = 4, Name = "David", Age = 21, GPA = 3.7, Courses = new List<string> { "Math", "Biology" } },
    new Student { Id = 5, Name = "George", Age = 21, GPA = 3.9, Courses = new List<string> { "Chemistry", "Biology" } },
    new Student { Id = 6, Name = "Jon", Age = 22, GPA = 3.9, Courses = new List<string> { "Chemistry", "Biology" } },
    new Student { Id = 7, Name = "Teryon", Age = 19, GPA = 3.9, Courses = new List<string> { "Chemistry", "Biology" } },
    new Student { Id = 7, Name = "Jamy", Age = 20, GPA = 3.9, Courses = new List<string> { "Chemistry", "Biology" } }
};

            var std1 = students.Where(x => x.Age > 20);
            Print(std1);
            Console.WriteLine("--------------------------");
            var std2 = students.Select(x => x.Name);
            foreach(var student in std2) Console.WriteLine(student);
            Console.WriteLine("--------------------------");
            var std3 = students.OrderBy(students => students.Age).ThenBy(x => x.GPA).ThenBy(x => x.Name);
            Print(std3);
            Console.WriteLine("--------------------------");
            var std4 = students.OrderByDescending(students => students.Age).ThenByDescending(x => x.GPA);
            Print(std4);
            Console.WriteLine("--------------------------");
            var std5 = students.GroupBy(x => x.Age);
            foreach(var group in std5)
            { 
                Console.WriteLine($"Age : {group.Key} :");
                foreach(var student in group) Console.WriteLine(student);
            }
            Console.WriteLine("--------------------------");
            var isfound = students.Any();
            Console.WriteLine(isfound.ToString());
            Console.WriteLine("--------------------------");
            var istrue = students.All(x=>x.Age>= 19);
            Console.WriteLine(istrue.ToString());
            Console.WriteLine("--------------------------");
            var std6 = students.First(x=>x.GPA== 3.9);
            var std7 = students.FirstOrDefault(x=>x.GPA== 3.9);
            var std10 = students.Find(x => x.Age == 3.9);
            //var std8 = students.Single(x => x.GPA == 3.9);
            //var std9 = students.SingleOrDefault(x => x.GPA == 3.9);
            Console.WriteLine(std6);
            Console.WriteLine("--------------------------");
            var std11 = students.OrderBy(x=>x.Age).Take(4);
            Print(std11);
            Console.WriteLine("--------------------------");
            var std12 = students.OrderBy(x=>x.Age).Skip(2);
            Print(std12);
            Console.WriteLine("--------------------------");
            var std13 = students.Select(x => x.Age).Distinct();
            foreach(var student in std13) Console.WriteLine( student );
            Console.WriteLine("--------------------------");
            Console.WriteLine(students.Count());
            Console.WriteLine("--------------------------");
            Console.WriteLine(students.Sum(x=>x.GPA));
            Console.WriteLine(students.Average(x=>x.GPA));
            Console.WriteLine("--------------------------");
            var found = students.Contains(std7);
            Console.Write(found);
            Console.WriteLine("--------------------------");
            var std14= students.Where(x => x.Age > 20).ToList();
            var std15= students.Where(x => x.Age > 20).ToArray();
            Console.WriteLine("--------------------------");
            var min = students.Min(x=>x.GPA);
            var max = students.Max(x=>x.GPA);
            Console.WriteLine($"Max : {max} Min : {min}");
        }
        public class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public double GPA { get; set; }
            public List<string> Courses { get; set; }

            public override string ToString()
            {
                return $"Id : {Id} - Name : {Name} - Age : {Age} - GPA : {GPA} ";

            }
        }
        static void Print (IEnumerable<Student> students)
        {
            foreach (Student student in students) Console.WriteLine(student);
        }
    }
}
