using System;
using System.Collections.Generic;

namespace UniversitySystem
{
    public class Person
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public decimal Salary { get; set; }
        public List<string> Addresses { get; set; } = new List<string>();

        public int CalculateAge()
        {
            return DateTime.Now.Year - DateOfBirth.Year;
        }

        public decimal CalculateSalary()
        {
            if (Salary < 0) throw new ArgumentException("Salary cannot be negative.");
            return Salary;
        }

        public List<string> GetAddresses() => Addresses;
    }

    public class Student : Person
    {
        public List<Course> Courses { get; set; } = new List<Course>();

        public double CalculateGPA()
        {
            if (Courses.Count == 0) return 0;
            double totalGrades = 0;
            foreach (var course in Courses)
            {
                totalGrades += course.GradeToPoint();
            }
            return totalGrades / Courses.Count;
        }
    }

    public class Instructor : Person
    {
        public Department Department { get; set; }
        public DateTime JoinDate { get; set; }

        public decimal CalculateBonus()
        {
            int yearsOfExperience = DateTime.Now.Year - JoinDate.Year;
            return yearsOfExperience * 1000; // Example bonus logic
        }
    }

    public class Course
    {
        public string Name { get; set; }
        public char Grade { get; set; }
        public List<Student> EnrolledStudents { get; set; } = new List<Student>();

        public double GradeToPoint()
        {
            return Grade switch
            {
                'A' => 4.0,
                'B' => 3.0,
                'C' => 2.0,
                'D' => 1.0,
                'F' => 0.0,
                _ => throw new ArgumentException("Invalid grade.")
            };
        }
    }

    public class Department
    {
        public string Name { get; set; }
        public Instructor Head { get; set; }
        public decimal Budget { get; set; }
        public List<Course> Courses { get; set; } = new List<Course>();
    }
}
