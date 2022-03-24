using Backend.Models;

namespace Backend.Data
{
    internal static class FakeData
    {
        internal static List<User> getAll() => new List<User> {
            new User{
                Id = 1,
                FirstName = "Musa",
                LastName = "Ugurlu",
                Email = "mu@sa.com",
                Password = "123456",
                Role = "admin"
            }
        };

        internal static List<Student> getAllStudents() => new List<Student>{
            new Student{
                Id = 1,
                FirstName = "Chinh",
                LastName = "Ngo",
                Classroom = "B1",
                HomeroomTeacher = "Black",
                BarcodeNumber = "123456678"
            },
            new Student{
                Id = 2,
                FirstName = "AAAA",
                LastName = "AAAA",
                Classroom = "A1",
                HomeroomTeacher = "ABlack",
                BarcodeNumber = "324353535"
            },
            new Student{
                Id = 3,
                FirstName = "BBBBB",
                LastName = "BBBB",
                Classroom = "B1",
                HomeroomTeacher = "Black",
                BarcodeNumber = "456789456"
            },
            new Student{
                Id = 4,
                FirstName = "CCCCC",
                LastName = "CCCC",
                Classroom = "C1",
                HomeroomTeacher = "CBlack",
                BarcodeNumber = "789456156"
            },
            new Student{
                Id = 5,
                FirstName = "DDDDD",
                LastName = "DDDDD",
                Classroom = "D1",
                HomeroomTeacher = "DBlack",
                BarcodeNumber = "123456789"
            }

        };

        internal static List<Room> getAllRooms() => new List<Room>{
            new Room{
                Id = 1,
                Name = "Room1",
                Description = "Room1"
            },
            new Room{
                Id = 2,
                Name = "Room2",
                Description = "Room2"
            }
        };

        internal static List<Carline> getAllCarlines() => new List<Carline>
        {
            new Carline{
                Id = 1,
                Name = "Carline1",
                IsActive = true

            },
            new Carline{
                Id = 2,
                Name = "Carline2",
                IsActive = false
            }
        };
    }
    
}