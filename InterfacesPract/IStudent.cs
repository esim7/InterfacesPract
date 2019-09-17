using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesPract
{
    public interface IStudent
    {
        string Name { get; set; }
        string FullName { get; set; }
        int[] Grades { get; set; }

        string GetName();
        string GetFullName();
        double GetAvgGrade();
    }
}
