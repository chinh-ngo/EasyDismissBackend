using Backend.Data;
using Backend.Helpers;
using Backend.Models;
using Microsoft.Extensions.Options;

namespace Backend.Services
{
    
    public class StudentsService
    {
        private readonly AppSettings _appSettings;

        public StudentsService(IOptions<AppSettings> appsettings)
        {
            _appSettings = appsettings.Value;
        }

        public List<Student> Students()
        {
            List<Student> students = FakeData.getAllStudents();

            return students;
        }

    }
}
