using EmployeeManager;

Employee employee = new Employee("Phil Harrison", "E4363868", 37.5);

Console.WriteLine(employee);
Console.WriteLine(employee.CalculateWage());
Console.WriteLine(employee.ToString());

employee.HoursWorked = 50;

Console.WriteLine(employee.CalculateWage());

// Employee Name and Number
Console.WriteLine("Welcome to the Employee System 2000");
Console.WriteLine("Please enter employee name:");
string employeeName = Console.ReadLine() ?? "";

while (!Employee.IsValidName(employeeName))
{
    Console.WriteLine("Invalid employee name entered - YOU MUST TRY AGAIN");
    Console.WriteLine("Please enter employee name (characters must total between 1 & 50):");

    employeeName = Console.ReadLine() ?? "";
}

Console.WriteLine("Please enter employee ID:");
string employeeID = Console.ReadLine() ?? "";

while (!Employee.IsValidID(employeeID))
{
    Console.WriteLine("Invalid employee ID entered - YOU MUST TRY AGAIN");
    Console.WriteLine("Please enter employee ID (1x Letter + 2x Digit):");

    employeeID = Console.ReadLine() ?? "";
}

Console.WriteLine("Valid employee ID entered");

Console.WriteLine("Please enter hours worked:");
string hoursInput = Console.ReadLine() ?? "0";

double hoursWorked;

while (!double.TryParse(hoursInput, out hoursWorked) ||
       !Employee.IsValidHours(hoursWorked))
{
    Console.WriteLine("Invalid hours entered - YOU MUST TRY AGAIN");
    Console.WriteLine("Please enter hours worked (between 1 and 100):");

    hoursInput = Console.ReadLine() ?? "0";
}

Employee employee1 = new Employee(employeeName, employeeID, hoursWorked);

double weeklyWage = employee1.CalculateWage();

Console.WriteLine();
Console.WriteLine($"The weekly wage is £{weeklyWage:F2}");
