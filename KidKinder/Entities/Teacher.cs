using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KidKinder.Entities
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string Title { get; set; }
        public string FieldOfStudy { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }        
        public string Image { get; set; }
    }
}