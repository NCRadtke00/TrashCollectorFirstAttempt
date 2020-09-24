using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrashCollector.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string CustomerId { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }

      
        [ForeignKey("PickUp")]
        public int PickUpID { get; set; }
        public PickUp PickUp { get; set; }
        public string InitialPickUp { get; set; }
        public string AdditionPickup { get; set; }
        public string DiscontinuePickUp { get; set; }
        public string PausePickUp { get; set; }
        public double Bill { get; set; } //decimal?

        [ForeignKey("Address")]
        public int AddressId { get; set; }
        public Address Address { get; set; }
        public string Street { get; set; }
        public string ApartmantOrSuiteNumber { get; set; }
        public string CityName { get; set; }
        public string StateName { get; set; }
        public string ZipCode { get; set; }
        public string Cordinates { get; set; }

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
    }
}
