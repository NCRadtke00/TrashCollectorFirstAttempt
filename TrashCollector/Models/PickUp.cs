using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class PickUp
    {
        [Key]
        public int pickUpId { get; set; }
        [ForeignKey ("employee")]
        public int employeeId { get; set; }
        public Employee employee { get; set; } 
        [ForeignKey("customers")] 
        public int customerId { get; set; }
        public Customer customers { get; set; }
      
        public DateTime PickUpDate { get; set; }
        public bool employeeCollectedTrash { get; set; }
        public bool employeeCollectedRecycling { get; set; }
        public bool customerWasTrashCollected { get; set; }
        public bool custoemrWasRecyclingCollected { get; set; }
    }
}
