using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskUpSolving
{
    internal class ScoreProcessor
    {
        public delegate bool ScoreCriteria(Student student);

        public List<Student> FilterStudents(List<Student> students,ScoreCriteria scoreCriteria)
        {
            var lst = new List<Student>();

            foreach (Student student in students)
            {
                if (scoreCriteria(student)) lst.Add(student);
            }
            return lst;
        }
        public double CalcAverage(List<Student> students,Func<List<Student>,double> average) { 

            //var avg = students.Sum(x=>x.Score) / students.Count();
            //return avg;

            return average(students);
        }
    }
}
