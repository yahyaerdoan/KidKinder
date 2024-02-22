using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KidKinder.Entities
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        
        public string FieldOfStudy { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }        
        public string Image { get; set; }

        public int BranchId { get; set; }
        public virtual Branch Branch { get; set; }
    }
}