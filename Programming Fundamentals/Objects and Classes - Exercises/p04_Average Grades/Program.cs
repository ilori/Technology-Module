using System;
using System.Collections.Generic;
using System.Linq;

namespace p04_Average_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().ToList();
                var name = input[0];

                var grades = new List<double>();

                for (int j = 1; j < input.Count; j++)
                {
                    grades.Add(double.Parse(input[j]));
                }

                var student = new Student(name, grades);

                students.Add(student);
            }
            foreach (var student in students.OrderBy(x => x.Name)
                .ThenByDescending(x => x.AverageGrade).Where(x => x.AverageGrade >= 5.00))
            {
                Console.WriteLine($"{student.Name} -> {student.AverageGrade:f2}");
            }
        }
    }

    public class Student
    {
        public Student(string name, List<double> grades)
        {
            Name = name;
            Grades = grades;
        }

        public string Name { get; set; }
        public List<double> Grades { get; set; }

        public double AverageGrade => Grades.Average();
    }
}