using System;
using System.ComponentModel.DataAnnotations;

namespace TrashCollector.Models
{
    public class PickUp
    {
        [Key]
        public int Id { get; set; }
        public int GetCustomersId { get; set; }
        public string DayOfWeek { get; set; }
        public DateTime? PickUpDay { get; set; }
        public bool CustomerTrashWasNotCollected { get; set; }
        public bool CustomerRecyclingWasNotCollected { get; set; }
        public DateTime? DiscontinuePickUp { get; set; }
        public DateTime? PausePickUp { get; set; }
        public double Bill { get; set; }
    }
}
