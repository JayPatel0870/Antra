using System.Collections.Generic;

namespace UniversitySystem
{
    public interface IPersonService
    {
        int CalculateAge();
        decimal CalculateSalary();
        List<string> GetAddresses();
    }

    public interface IStudentService : IPersonService
    {
        double CalculateGPA();
    }

    public interface IInstructorService : IPersonService
    {
        decimal CalculateBonus();
    }

    public interface ICourseService
    {
        double GradeToPoint();
    }

    public interface IDepartmentService
    {
        void AssignHead(Instructor instructor);
    }
}
