using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Activity
    {
        public int Id { get; set; }
        public string Omschrijving { get; set; }
        public int AantalStudenten { get; set; }
        public int AantalBegeleiders { get; set; }
    }
}
