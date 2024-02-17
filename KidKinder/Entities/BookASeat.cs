using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KidKinder.Entities
{
    public class BookASeat
    {
        [Key]
        public int BookASeatId { get; set; }
        public int ClassRoomId { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }       
        public string Email { get; set; }
        public ClassRoom ClassRoom { get; set; }
    }
}