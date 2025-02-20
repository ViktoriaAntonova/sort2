using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort2
{
    internal class Student
    {
        public string Name { get; set; }
        public double AverageGrade { get; set; }

        public Student(string name, double avgGrade)
        {
            Name = name;
            AverageGrade = avgGrade;
        }
        public override string ToString()
        {
            return $"{Name}: {AverageGrade}"; ;
        }
    }
}
