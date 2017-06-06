using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentMvc.Models
{
    public class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool isActive { get; set; }
        public string sex { get; set; }
    }
}
