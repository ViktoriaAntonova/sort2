using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string input;

            Console.WriteLine("break - za da prikluchite");

            while (true)
            {
                Console.Write("Ime: ");
                input = Console.ReadLine();

                if (input.ToLower() == "break")
                {
                    break;
                }

                string name = input;

                Console.Write("Average grade: ");
                double averageGrade = double.Parse(Console.ReadLine());
                students.Add(new Student(name, averageGrade));
            }
            InsertionSortByGrade(students);
            InsertionSortByName(students);
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
        static void InsertionSortByGrade(List<Student> students)
        {
            for (int i = 1; i < students.Count; i++)
            {
                Student current = students[i];
                int j = i - 1;
                while (j >= 0 && students[j].AverageGrade > current.AverageGrade)
                {
                    students[j + 1] = students[j];
                    j--;
                }
                students[j + 1] = current;
            }
        }
        static void InsertionSortByName(List<Student> students)
        {
            for (int i = 1; i < students.Count; i++)
            {
                Student current = students[i];
                int j = i - 1;
                while (j >= 0 && string.Compare(students[j].Name, current.Name) > 0)
                {
                    students[j + 1] = students[j];
                    j--;
                }
                students[j + 1] = current;
            }
        }
    }
}
