using System;

namespace InterfacesPract
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Esimzhan", "Makishev Esimzhan Aidarkhanovich", 6);
            Console.WriteLine("Введите " + student.Grades.Length + " оценок студента " + student.Name);
            for (int i = 0; i < student.Grades.Length; i++)
            {
                int.TryParse(Console.ReadLine(), out student.Grades[i]);
            }
            Console.WriteLine(student.GetName());
            Console.WriteLine(student.GetFullName());
            Console.WriteLine(student.GetAvgGrade());
        }
    }
}
