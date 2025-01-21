using Pratik39;

// List of classes available
List<Class> classes =
[
    new Class { ClassId = 1, ClassName = "Math" },
    new Class { ClassId = 2, ClassName = "Science" },
    new Class { ClassId = 3, ClassName = "History" },
];

// List of students enrolled in classes
List<Student> students =
[
    new Student { StudentId = 1, StudentName = "John Doe", ClassId = 1},
    new Student { StudentId = 2, StudentName = "Jane Doe", ClassId = 2},
    new Student { StudentId = 3, StudentName = "John Smith", ClassId = 3},
    new Student { StudentId = 4, StudentName = "Jane Smith", ClassId = 1},
];

// Grouping students by their class names
var groupedStudents = students.Join(classes, student => student.ClassId, @class => @class.ClassId, (student, @class) => new { student.StudentName, @class.ClassName })
                              .GroupBy(x => x.ClassName)
                              .Select(x => new { ClassName = x.Key, Students = x.Select(y => y.StudentName) });

// Displaying the grouped students by class
foreach (var group in groupedStudents)
{
    Console.WriteLine($"Class: {group.ClassName}");
    foreach (var student in group.Students)
    {
        Console.WriteLine($"- {student}");
    }
}