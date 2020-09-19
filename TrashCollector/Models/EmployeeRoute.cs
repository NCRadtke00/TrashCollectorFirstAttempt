using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class EmployeeRoute
    {
        public Employee employee { get; set; } 
        public List<Customer> customers { get; set; }
        public bool wasTrashCollected { get; set; }
        public bool wasRecyclingCollected { get; set; }
    }
}
