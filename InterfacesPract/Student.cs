using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesPract
{
    public class Student : IStudent
    {
        public string Name { get; set; }
        public string FullName { get; set; }
        public int[] Grades { get; set; }
        public int GradesCount { get; set; }

        public Student(string name, string fullName, int gradesCount)
        {
            Name = name;
            FullName = fullName;
            GradesCount = gradesCount;
            Grades = new int[GradesCount];
        }

        public double GetAvgGrade()
        {
            int result = 0;
            for (int i = 0; i < Grades.Length; i++)
            {
                result += Grades[i];
            }
            result /= Grades.Length;
            return (double) result;
        }

        public string GetFullName()
        {
            return FullName;
        }

        public string GetName()
        {
            return Name;
        }
    }
}
