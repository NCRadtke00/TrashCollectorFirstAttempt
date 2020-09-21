using Microsoft.AspNetCore.Identity;
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
        public int Id { get; set; }
        public Employee employee { get; set; } 

        [ForeignKey("customer")]
        public int customersId { get; set; }
        public Customer customers { get; set; }
        
        [ForeignKey("employee")]
        public int employeesId { get; set; }
        public Employee employees { get; set; }
        
        public bool customerTrashWasNotCollected { get; set; }
        public bool customerRecyclingWasNotCollected { get; set; }


    }
}
