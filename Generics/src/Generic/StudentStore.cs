using System;
using System.Collections.Generic;
using System.Text;

namespace Generic
{
    public class StudentStore
    {
        public List<Student> students { get; set; }

        public void Add(Student student)
        {
            students.Add(student);
        }

        public Student GetById(int id)
        {
            foreach (Student student in students)
            {
                if (id == student.id)
                    return student;
            }

            return null;
        }

        public List<Student> GetAll() => students;

        public void Remove(int id)
        {
            Student student = GetById(id);
            if (student != null)
            {
                students.Remove(student);
            }
        }
    }
}
