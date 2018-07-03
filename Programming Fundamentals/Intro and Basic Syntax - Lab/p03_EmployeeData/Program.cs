using System;

namespace p03_EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var id = int.Parse(Console.ReadLine());
            var salary = double.Parse(Console.ReadLine());
            Console.WriteLine($"Name: {name}\nAge: {age}\nEmployee ID: {id:d8}\nSalary: {salary:f2}");
        }
    }
}