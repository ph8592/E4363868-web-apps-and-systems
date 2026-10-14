using StudentList;

Console.WriteLine("Student List App");

#region Initialise Student List
List<Student> studentList = new List<Student>();

studentList.AddRange(
    new Student("John", "Doe", 20, "Computer Science", 85.5, 2022),
    new Student("Jane", "Smith", 22, "Mathematics", 90.0, 2021),
    new Student("Alice", "Johnson", 19, "Physics", 88.0, 2022),
    new Student("Bob", "Brown", 21, "Chemistry", 75.5, 2020),
    new Student("Charlie", "Davis", 23, "Biology", 92.0, 2021),
    new Student("Eve", "Miller", 20, "Engineering", 80.0, 2022),
    new Student("Frank", "Wilson", 22, "Economics", 78.5, 2020),
    new Student("Grace", "Taylor", 19, "History", 85.0, 2021),
    new Student("Hannah", "Anderson", 21, "Philosophy", 88.5, 2022),
    new Student("Ian", "Thomas", 23, "Art", 90.0, 2020),
    new Student("Jack", "Moore", 20, "Music", 82.0, 2021),
    new Student("Karen", "Jackson", 22, "Computer Science", 87.5, 2022),
    new Student("Leo", "White", 19, "Mathematics", 91.0, 2020),
    new Student("Mia", "Harris", 21, "Physics", 89.5, 2021),
    new Student("Noah", "Martin", 23, "Chemistry", 76.0, 2022),
    new Student("Olivia", "Thompson", 20, "Biology", 93.0, 2020)
    );
#endregion

DisplayStudentList(studentList);

Console.WriteLine("\nFilter by course and sort by mark");
var filteredAndSortedStudents = studentList
    .Where(s => s.Course == "Computer Science")
    .OrderByDescending(s => s.Mark)
    .ToList();
DisplayStudentList(filteredAndSortedStudents);

Console.WriteLine("\nStudents who enrolled after 2020");
var enrolledAfter2020 = studentList
    .Where(s => s.EnrolmentYear > 2020)
    .OrderBy<Student, int>(s => s.EnrolmentYear)
    .ToList();
DisplayStudentList(enrolledAfter2020);

Console.WriteLine("\nAverage mark by course");
var averageMarkByCourse = studentList
    .GroupBy(s => s.Course)
    .Select(g => new { Course = g.Key, AverageMark = g.Average(s => s.Mark) })
    .ToList();
foreach(var item in averageMarkByCourse)
{
    Console.WriteLine($"Course: {item.Course}, Average Mark: {item.AverageMark:F2}");
}





#region Local Functions
static void DisplayStudentList(List<Student> studentList)
{
    foreach (var student in studentList)
    {
        Console.WriteLine(student.ToString());
    }
}
#endregion
