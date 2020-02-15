using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel;

namespace BakerApp.Models
{
    public class Client
    {
        public int Id { get; set; }
        [DisplayName("Nazwa")]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        public string Region { get; set; }
        public int Contact { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}