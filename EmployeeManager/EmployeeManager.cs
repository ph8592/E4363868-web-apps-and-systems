using System;
using System.Collections.Generic;
using EmployeeManager;

namespace EmployeeManagerService
{
    public class EmployeeManagerService
    {
        private List<Employee> employees = new List<Employee>();

        public void StartMenu()
        {
            while(true)
            {
                DisplayMenu();
            }
            
        }

        private void DisplayMenu()
        {
            Console.WriteLine("EMPLOYEE MANAGER 2000");
            Console.WriteLine("Main Menu:");
            Console.WriteLine("1. Add employee");
            Console.WriteLine("2. List employees");
            Console.WriteLine("3. Remove employee");
            Console.WriteLine("4. Exit system");

            Console.WriteLine("Please enter the menu option number:");
            String option = Console.ReadLine() ?? "";

            if (int.TryParse(option, out int optionNumber))
            {
                ProcessMenuSelection(optionNumber);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }

        private void ProcessMenuSelection(int option)
        {
            switch (option)
            {
                case 1:
                    AddEmployee();
                    break;
                case 2:
                    ListEmployees();
                    break;
                case 3:
                    RemoveEmployee();
                    break;
                case 4:
                    ExitSystem();
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }

        private void AddEmployee()
        {
            Console.WriteLine("Enter employee name:");
            string employeeName = Console.ReadLine() ?? "";
            while (!Employee.IsValidName(employeeName))
            {
                Console.WriteLine("Invalid employee name entered - YOU MUST TRY AGAIN");
                Console.WriteLine("Please enter employee name (characters must total between 1 & 50):");
                employeeName = Console.ReadLine() ?? "";
            }
            Console.WriteLine("Enter employee ID:");
            string employeeID = Console.ReadLine() ?? "";
            while (!Employee.IsValidID(employeeID))
            {
                Console.WriteLine("Invalid employee ID entered - YOU MUST TRY AGAIN");
                Console.WriteLine("Please enter employee ID (1x Letter + 2x Digit):");
                employeeID = Console.ReadLine() ?? "";
            }
            Console.WriteLine("Enter hours worked:");
            string hoursInput = Console.ReadLine() ?? "0";
            double hoursWorked;
            while (!double.TryParse(hoursInput, out hoursWorked) || !Employee.IsValidHours(hoursWorked))
            {
                Console.WriteLine("Invalid hours entered - YOU MUST TRY AGAIN");
                Console.WriteLine("Please enter hours worked (between 1 and 100):");
                hoursInput = Console.ReadLine() ?? "0";
            }
            Employee newEmployee = new Employee(employeeName, employeeID, hoursWorked);
            employees.Add(newEmployee);
            Console.WriteLine($"Employee {newEmployee} added successfully.");
        }

        private void ListEmployees()
        {
            if (employees.Count == 0)
            {
                Console.WriteLine("No employees to display!");
            }
            else
            {
                Console.WriteLine("List of employees:");

                for (int i = 0; i < employees.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {employees[i]}");
                }
            }
        }

        private void RemoveEmployee()
        {
            if (employees.Count == 0)
            {
                Console.WriteLine("No employees to remove!");
                return;
            }

            ListEmployees();

            Console.WriteLine("Enter the position number of the employee to remove:");
            string input = Console.ReadLine() ?? "";

            if (int.TryParse(input, out int position) &&
                position >= 1 &&
                position <= employees.Count)
            {
                Employee employeeToRemove = employees[position - 1];

                employees.RemoveAt(position - 1);

                Console.WriteLine($"Employee {employeeToRemove} removed.");
            }
            else
            {
                Console.WriteLine("Invalid employee position.");
            }
        }

        private void ExitSystem()
        {
            Console.WriteLine("Exiting!");
            Environment.Exit(0);
        }
    }
}
