using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrashCollector.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string customerId { get; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phoneNumber { get; set; }

      
        [ForeignKey("PickUp")]
        public int PickUpID { get; set; }
        public PickUp PickUp { get; set; }
        public string initialPickUp { get; set; }
        public string additionPickup { get; set; }
        public string discontinuePickUps { get; set; }
        public string pausePickUps { get; set; }
        public double bill { get; set; } //decimal?

        [ForeignKey("Address")]
        public int AddressId { get; set; }
        public Address Address { get; set; }
        public string street { get; set; }
        public string apartmantOrSuiteNumber { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zipCode { get; set; }
        public string cordinates { get; set; }

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
    }
}
