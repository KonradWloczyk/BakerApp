using System;
using System.ComponentModel.DataAnnotations;

namespace BakerApp.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        public string Region { get; set; }
        public int Contact { get; set; }
    }
}