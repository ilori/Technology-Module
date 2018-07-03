using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace p08_MentorGroup
{
    class Program
    {
        static void Main()
        {
            var firstInput = Console.ReadLine();
            var students = new Dictionary<string, Student>();

            while (firstInput != "end of dates")
            {
                var tokens = firstInput.Split(' ', ',').ToList();
                var student = new Student();
                student.Name = tokens[0];
                student.Dates = new List<DateTime>();
                if (tokens.Count > 1)
                {
                    student.Dates.AddRange(tokens.Skip(1).Select(x =>
                        DateTime.ParseExact(x, "dd'/'MM'/'yyyy", CultureInfo.InvariantCulture)));
                }
                if (!students.ContainsKey(student.Name))
                {
                    students[student.Name] = student;
                }
                else
                {
                    students[student.Name].Dates.AddRange(student.Dates);
                }
                firstInput = Console.ReadLine();
            }
            var secondInput = Console.ReadLine();
            while (secondInput != "end of comments")
            {
                var tokens = secondInput.Split('-').ToList();
                var name = tokens[0];
                var comments = tokens[1];
                if (students.ContainsKey(name))
                {
                    if (students[name].Comments == null)
                    {
                        students[name].Comments = new List<string>();
                    }
                    students[name].Comments.Add(comments);
                }

                secondInput = Console.ReadLine();
            }
            foreach (var student in students.Values.OrderBy(x => x.Name))
            {
                Console.WriteLine($"{student.Name}");
                Console.WriteLine("Comments: ");
                if (student.Comments != null)
                {
                    foreach (var comment in student.Comments)
                    {
                        Console.WriteLine($"- {comment}");
                    }
                }
                Console.WriteLine("Dates attended: ");
                foreach (var date in student.Dates.OrderBy(x=>x))
                {
                    Console.WriteLine($"-- {date:dd'/'MM'/'yyyy}");
                }
            }
        }
    }


    public class Student
    {
        public string Name { get; set; }
        public List<string> Comments { get; set; }
        public List<DateTime> Dates { get; set; }
    }
}