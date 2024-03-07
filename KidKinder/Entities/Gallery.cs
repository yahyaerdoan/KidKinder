using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KidKinder.Entities
{
    public class Gallery
    {
        public int GalleryId { get; set; }
        public int CategoryId { get; set; }        
        public string Description { get; set; }        
        public string Image1 { get; set; }    
        public string Image2 { get; set; }    
        public bool Statu { get; set; }
    }
}