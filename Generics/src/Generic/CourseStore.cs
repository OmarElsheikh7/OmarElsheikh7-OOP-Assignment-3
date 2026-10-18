using System;
using System.Collections.Generic;
using System.Text;

namespace Generic
{
    public class CourseStore
    {
        public List<Course> courses { get; set; }

        public void Add(Course course)
        {
            courses.Add(course);
        }

        public Course GetById(int id)
        {
            foreach (Course course in courses)
            {
                if (id == course.Id)
                    return course;
            }

            return null;
        }

        public List<Course> GetAll() => courses;

        public void Remove(int id)
        {
            Course course = GetById(id);
            if (course != null)
            {
                courses.Remove(course);
            }
        }
    }
}
