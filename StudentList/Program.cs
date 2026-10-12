using StudentList;

Console.WriteLine("Student List App");

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

foreach (var student in studentList)
{
    Console.WriteLine(student.ToString());
} 