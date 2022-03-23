using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Backend.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Classroom { get; set; }

        public string HomeroomTeacher { get; set; }

        public string BarcodeNumber { get; set; }

    }
}
