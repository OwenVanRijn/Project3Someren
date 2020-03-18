using System.Collections.Generic;

namespace SomerenModel
{
    public class Room
    {
        public int Number { get; set; } // RoomNumber, e.g. 206
        public int Capacity { get; set;  } // number of beds, either 4,6,8,12 or 16
        public bool Type { get; set; } // student = false, teacher = true
        public List<Student> Students { get; set; }
        public List<Lecturer> Lecturers { get; set; }
    }
}
