using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManager
{
    public class Employee
    {
        private string hoursWorked;

        // Employee properties
        public string EmployeeName { get; set; }
        public string EmployeeID { get; set; }
        public double HoursWorked { get; set; }
        public double HourlyRate { get; set; }

        // Constructor 
        public Employee(string employeeName, string employeeID, double hoursWorked)
        {
            EmployeeName = employeeName;
            EmployeeID = employeeID;
            HoursWorked = hoursWorked;
            // Default hourly rate
            HourlyRate = 9.5;
        }

        public Employee(string employeeName, string employeeID, string hoursWorked)
        {
            EmployeeName = employeeName;
            EmployeeID = employeeID;
            this.hoursWorked = hoursWorked;
        }

        // Returns employee in readable format
        public override string ToString()
        {
            return $"{EmployeeName} ({EmployeeID})";
        }

        // Calculates wage: hours by rate
        public double CalculateWage()
        {
            return HoursWorked * HourlyRate;
        }

        public static bool IsValidName(string name)
        {
            if (name.Length > 50 ||
                name.Length < 1)
            {
                return false;
            }

            foreach (char character in name)
            {
                if (char.IsDigit(character))
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Oportunity 1 : consider using a regular expression
        /// Opportunity 2: it could and maybe shoul be ts own type investigare the c# record
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool IsValidID(string id)
        {
            if (id.Length != 3 ||
                !char.IsLetter(id[0]) ||
                !char.IsDigit(id[1]) ||
                !char.IsDigit(id[2]))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool IsValidHours(double hoursWorked)
        {
            if (hoursWorked > 100 ||
                hoursWorked < 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
