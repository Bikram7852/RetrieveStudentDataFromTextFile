using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary
{
    public class StudentData
    {
        private List<Student> students;

        public StudentData()
        {
            students = new List<Student>();
        }

        public void ReadFromFile(string filename)
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    students.Add(new Student(parts[0], parts[1]));
                }
            }
        }

        public void Sort()
        {
            students.Sort((x, y) => x.Name.CompareTo(y.Name));
        }

        public List<Student> GetStudents()
        {
            return students;
        }

        public Student FindStudentByName(string name)
        {
            return students.Find(student => student.Name.ToUpper() == name.ToUpper());
        }
    }
}
