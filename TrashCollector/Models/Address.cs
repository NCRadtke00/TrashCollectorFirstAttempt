using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        public string streetAddress { get; set; }
        public string apartmantOrSuiteNumber { get; set; }
        public string cityName { get; set; }
        public string stateName { get; set; }
        public string zipCode { get; set; }
        public string cordinates { get; set; }
    }
}
