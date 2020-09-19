using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class Customer
    { 
        [Key]
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string CustomersStreet { get; set; }
        public string CustomersCity { get; set; }
        public string CustomersState { get; set; }
        public string CustomersZipCode { get; set; }
        //adjustment to location if needed (pin drop?)
        public string initialPickUp { get; set; }
        public string additionPickup { get; set; } 
        public string discontinuePickUps { get; set;} //Delete customer from employee route, dont delete information or data - put in an inactive list
        public string pausePickUps { get; set; } 
        public double CustomersBill { get; set; }
        public bool hasTrashBeenCollected { get; set; }
        public bool wasRecyclingPickedUp {get;set;} 

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
    }
}
