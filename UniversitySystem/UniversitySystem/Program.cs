using System;

namespace UniversitySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the University System!");

            // Create a sample student
            Student student = new Student
            {
                Name = "John Doe",
                DateOfBirth = new DateTime(2000, 1, 1),
                Salary = 0, // Students don't have salaries
                Courses = new System.Collections.Generic.List<Course>
                {
                    new Course { Name = "Mathematics", Grade = 'A' },
                    new Course { Name = "Physics", Grade = 'B' }
                }
            };

            Console.WriteLine($"{student.Name}'s GPA: {student.CalculateGPA():0.00}");

            // Create a sample instructor
            Instructor instructor = new Instructor
            {
                Name = "Dr. Smith",
                DateOfBirth = new DateTime(1980, 6, 15),
                Salary = 80000,
                JoinDate = new DateTime(2010, 8, 1),
                Department = new Department { Name = "Computer Science" }
            };

            Console.WriteLine($"{instructor.Name}'s Age: {instructor.CalculateAge()}");
            Console.WriteLine($"{instructor.Name}'s Bonus: ${instructor.CalculateBonus():0.00}");
        }
    }
}
