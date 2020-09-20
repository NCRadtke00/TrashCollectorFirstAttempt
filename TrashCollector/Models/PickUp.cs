using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class PickUp
    {
        [Key]
        public Employee employee { get; set; } 
        public List<Customer> customers { get; set; }
        public bool customerTrashWasNotCollected { get; set; }
        public bool customerRecyclingWasNotCollected { get; set; }
    }
}
