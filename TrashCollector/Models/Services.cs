using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class Services
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Active Account" )]
        [DefaultValue(true)]
        public bool IsAccActive { get; set; }
        [Display(Name = "Start Account Suspension")]
        public DateTime? StartAccSuspension { get; set; }
        [Display(Name = "End Account Suspension")]
        public DateTime? EndAccSuspension { get; set; }
        [Display(Name = "Extra Pickup")]
        public DateTime? ExtraPickup { get; set; }
        [Display(Name = "Pickup Day")]
        public DayOfWeek PickupDay { get; set; }

    }
}
