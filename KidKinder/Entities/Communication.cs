using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KidKinder.Entities
{
    public class Communication
    {
        public int CommunicationId { get; set; }
        public string Title { get; set; }
        public string Header { get; set; }
        public string Descripction { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string OpeningHour { get; set; }
        public string Day { get; set; }
        public DateTime Hour { get; set; }
    }
}