using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HandyApp.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Requires more than 2 letters  ")]
        public string Name { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = " please enter a task that has more than 2 letters")]
        public string Tasks { get; set; }

        [Required]
        [Phone(ErrorMessage = " Please enter a valid phone number")]
        public string Telephone { get; set; }

        [Required]
        [MinLength(4, ErrorMessage = " please enter a Street name  that has more than 4 letters")]
        public string Address { get; set; }

        [Url]
        public string? ImageUrl { get; set; }
    }
}