using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KidKinder.Entities
{
    public class ClassRoom
    {
        [Key]
        public int ClassRoomId { get; set; }
        public string Title { get; set; }
        public string Header { get; set; }
        public string Descripction { get; set; }
        public string AgeOfKid { get; set; }
        public byte TotalSeat { get; set; }
        public string ClassTime { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public List<BookASeat> BookASeats { get; set; }
    }
}