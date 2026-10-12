using System;
using System.Collections.Generic;
using System.Text;

namespace StudentList
{
    public class Student
    {
        public string Forename { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Course { get; set; }
        public double Mark { get; set; }
        public int EnrolmentYear { get; set; } // Not DateTime as it is only the year of enrolment


        public Student(string forename, string surname, int age, string course, double mark, int enrolmentYear)
        {
            Forename = forename;
            Surname = surname;
            Age = age;
            Course = course;
            Mark = mark;
            EnrolmentYear = enrolmentYear;
        }

        public override string ToString()
        {
            return $"Name: {Forename} {Surname}, Age: {Age}, Course: {Course}, Mark: {Mark}, Enrolment Year: {EnrolmentYear}";
        }
    }
}
