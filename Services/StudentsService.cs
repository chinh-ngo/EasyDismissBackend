using Backend.Data;
using Backend.Helpers;
using Backend.Models;
using Microsoft.Extensions.Options;

namespace Backend.Services
{
    
    public class StudentsService
    {
        private EDDbContext _dbContext;
        List<Student> _students = FakeData.getAllStudents();

        public StudentsService(EDDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Student> Students()
        {
            return _students;
        }

        public Student GetStudentById(long id)
        {
            return _students.Single(u => u.Id == id);
        }


    }
}
