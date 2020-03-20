using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    class Kassa
    {
        public class Student
        {
            public string name { get; set; }
            public int number { get; set; } // StudentNumber, e.g. 474791
            public DateTime birthDate { get; set; }

        }
        public class Drink
        {
            public decimal price { get; set; }
            public decimal btw { get; set; }
            public int amount { get; set; }
            public string name { get; set; }
        }

    }
}
