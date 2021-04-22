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

        public string Name { get; set; }

        public string Tasks { get; set; }

        public string Telephone { get; set; }

        public string Address { get; set; }

        public string ImageUrl { get; set; }
    }
}
