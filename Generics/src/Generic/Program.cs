using Generic;

var studentStore = new Store<Student>();
studentStore.Add(new Student { Id = 1, name = "Alice" });
studentStore.Add(new Student { Id = 2, name = "Bob" });
studentStore.Add(new Student { Id = 3, name = "Charlie" });
studentStore.Add(new Student { Id = 4, name = "David" });
studentStore.Add(new Student { Id = 5, name = "Eve" });

// 2. Put 3 courses in a Store<Course>
var courseStore = new Store<Course>();
courseStore.Add(new Course { Id = 101, Title = "C# Basics", Price = 1000m });
courseStore.Add(new Course { Id = 102, Title = "OOP", Price = 1500m });
courseStore.Add(new Course { Id = 103, Title = "Data Structures", Price = 2000m });

// 3. Get one of each by id
var foundStudent = studentStore.GetById(3);
Console.WriteLine($"Found Student: {foundStudent.name}");

var foundCourse = courseStore.GetById(102);
Console.WriteLine($"Found Course: {foundCourse.Title}");

// 4. Add a student with an id that already exists - catch the exception
try
{
    studentStore.Add(new Student { Id = 1, name = "Duplicate Alice" });
}
catch (Exception ex)
{
    Console.WriteLine($"\nException: {ex.Message}");
}

// 5. Print page 2 (size 2) of the students
Console.WriteLine("\nPage 2 of Students (Size 2):");
var page2Students = studentStore.GetAll().Values.Page(2, 2);
foreach (var student in page2Students)
{
    Console.WriteLine($"- {student.name}");
}

// 6. Call FindById on a plain List<Course>
var plainCourseList = new List<Course>
            {
                new Course { Id = 201, Title = "SQL", Price = 1200m },
                new Course { Id = 202, Title = "MongoDB", Price = 1300m }
            };
var foundInList = plainCourseList.FindById(201);
Console.WriteLine($"\nFound in plain list: {foundInList.Title}");

// 7. Leave new Store<string>() as a commented-out line marked "must NOT compile"

// var stringStore = new Store<string>(); // must NOT compile