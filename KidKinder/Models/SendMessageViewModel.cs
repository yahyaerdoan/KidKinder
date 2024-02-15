using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KidKinder.Models
{
    public class SendMessageViewModel
    {
        [Required(ErrorMessage = "Can't be empty")]
        [StringLength(30, ErrorMessage = "Max 30 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Can't be empty")]
        [StringLength(30, ErrorMessage = "Max 30 characters")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Can't be empty")]
        [StringLength(30, ErrorMessage = "Max 30 characters")]
        [EmailAddress(ErrorMessage ="Use valid mail")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Can't be empty")]
        [StringLength(30,ErrorMessage = "Max 30 characters")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Can't be empty")]
        [StringLength(30, ErrorMessage = "Max 30 characters")]
        public string Header { get; set; }

        [Required(ErrorMessage = "Can't be empty")]
        [StringLength(30, ErrorMessage = "Max 30 characters")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Can't be empty")]
        [StringLength(30, ErrorMessage = "Max 30 characters")]
        [MinLength(10,ErrorMessage ="Must more 10 characters")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Can't be empty")]
        [StringLength(30, ErrorMessage = "Max 30 characters")]
        public string Message { get; set; }
    }
}