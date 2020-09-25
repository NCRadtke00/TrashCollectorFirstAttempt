using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrashCollector.Models
{
    public class Customer
    {
        [NotMapped]
        public double Longitude { get; set; }
        [NotMapped]
        public double Latitude { get; set; }

        [Key]
        public int Id { get; set; }
        public string CustomerId { get; }
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [DisplayName("Phone Number")]
        public string PhoneNumber { get; set; }

      
        [ForeignKey("PickUp")]
        public int PickUpID { get; set; }
        public PickUp PickUp { get; set; }
        [DisplayName("Initial PickUp")]
        public string InitialPickUp { get; set; }
        [DisplayName("Additional PickUp")]
        public string AdditionalPickup { get; set; }
        [DisplayName("Discontinue PickUp")]
        public string DiscontinuePickUp { get; set; }
        [DisplayName("Pause PickUp")]
        public string PausePickUp { get; set; }
        [DisplayName("Trash Was Not Collected")]
        public bool TrashWasNotCollected { get; set; }
        [DisplayName("Recycling Was Not Collected")]
        public bool RecyclingWasNotCollected { get; set; }
        [DisplayName("Bill")]
        public double Bill { get; set; } //decimal?

        [ForeignKey("Address")]
        public int AddressId { get; set; }
        public Address Address { get; set; }
        [DisplayName("Street")]
        public string Street { get; set; }
        [DisplayName("Apartmant Or Suite Number")]
        public string ApartmantOrSuiteNumber { get; set; }
        [DisplayName("City Name")]
        public string CityName { get; set; }
        [DisplayName("State Name")]
        public string StateName { get; set; }
        [DisplayName("Zip Code")]
        public string ZipCode { get; set; }
        [DisplayName("Cordinates")]
        public string Cordinates { get; set; }

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
    }
}
