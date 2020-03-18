using System.Collections.Generic;

namespace SomerenModel
{
    public class Room
    {
        public int number { get; set; } // RoomNumber, e.g. 206
        public int capacity { get; set;  } // number of beds, either 4,6,8,12 or 16
        public bool type { get; set; } // student = false, teacher = true
        public List<Student> students { get; set; }
        public List<Lecturer> lecturers { get; set; }
    }
}
