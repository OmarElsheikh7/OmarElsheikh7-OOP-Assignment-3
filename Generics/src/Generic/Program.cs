using Generic;

var studentStore = new Store<Student>();
var courseStore = new Store<Course>();

studentStore.Add(new Student { Id = 1, name = "Alice" });
courseStore.Add(new Course { Id = 101, Title = "C# Advanced", Price = 1500m });

var student = studentStore.GetById(1);
Console.WriteLine($"Found Student: {student.name}");

var course = courseStore.GetById(101);
Console.WriteLine($"Found Course: {course.Title}");