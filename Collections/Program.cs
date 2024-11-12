using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var std1 = new Student {  Name = "ffff ", Score = 50 };
            var std2 = new Student {  Name = "ffff ", Score = 50 };
            Student[] students =
            {
                new Student{Name = "Ahmed ", Score = 90},
                new Student{Name = "Mohamed ", Score = 80},
                new Student{Name = "Mohamoud ", Score = 70},

            };

            var stds = new List<Student>(3);
            stds.Add(new Student { Name = "Sameh ", Score = 90 });
            Print(stds);
            Console.WriteLine("--------------------------");
            stds.AddRange(students);
            Print(stds);
            Console.WriteLine("--------------------------");
            stds.Add(new Student { Name = "Ibrahim ", Score = 50 });
            stds.Add(new Student { Name = "Ibrahim ", Score = 50 });
            stds.Add(new Student { Name = "Ibrahim ", Score = 50 });

            stds.Insert(3, std1 );
            //stds.Remove(std1);
            
            //stds.RemoveAt(3);

            var isfound = stds.Contains(std1);
            Console.WriteLine(isfound);
            Print(stds);
            Console.WriteLine("--------------------------");

            List<string> strings = new List<string>
            {
                "kkkk",
                "hhhhhhh",
                "jjjjjjjj"
            };
            
            Console.WriteLine(strings.Contains("h"));


            Console.WriteLine("--------------------------");

            Dictionary<int,string> s = new Dictionary<int,string>();
            s.Add(1, "Ahmed");
            s.Add(2, "Ahmed");
            s.Add(3, "Ahmed");
            // [{(key),(valuye)}{(key),(valuye)}]
            foreach (var item in s) Console.WriteLine($"{item.Key} => {item.Value}");
            Console.WriteLine("--------------------------");
            s.Remove(2);
            foreach (var item in s) Console.WriteLine($"{item.Key} => {item.Value}");
            Console.WriteLine("--------------------------");
            s.Clear();
            Console.WriteLine(s.Count);
        }
        class Student
        {
            public string Name { get; set; }
            public int Score { get; set; }
            public override string ToString()
            {
                return $"Name : {Name} => {Score}";
            }
        }
        static void Print(List<Student> students)
        {
            foreach (Student student in students) Console.WriteLine(student);

            Console.WriteLine($"Capacity : {students.Capacity}");
            Console.WriteLine($"Count : {students.Count}");
        }
    }
}
