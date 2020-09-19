using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class EmployeeViewCustomerInformation
    {
        public Employee employee { get; set; } 
        public List<Customer>  customers { get; set; }
        public string PickADay { get; set; }
        public List<Customer> dayPicked { get; set; }
        public bool wasTrashPickedUp { get; set; }


    }
}
