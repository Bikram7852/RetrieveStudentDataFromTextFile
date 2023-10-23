using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentLibrary;

namespace RetrieveStudentDataFromTextFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentData studentData = new StudentData();

            studentData.ReadFromFile("students.txt");

            studentData.Sort();

            Console.WriteLine("Student Data");
            Console.WriteLine("------------");
            foreach (Student student in studentData.GetStudents())
            {
                Console.WriteLine($"{student.Name} - {student.Class}");
            }

            Console.WriteLine("Do you want to search for a student by name? (y/n)");
            string response = Console.ReadLine();

            if (response == "y")
            {
                Console.WriteLine("Enter the student's name: ");
                string name = Console.ReadLine();

                Student student = studentData.FindStudentByName(name);

                if (student != null)
                {
                    Console.WriteLine("Student found:");
                    Console.WriteLine($"{student.Name} - {student.Class}");
                }
                else
                {
                    Console.WriteLine("No student found with the name " + name);
                }
            }
            else 
            { 
                Environment.Exit(0); 
            }
            Console.ReadLine();
        }
    }
}
