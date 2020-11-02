using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class CustomerViewModel
    {
        public Address Address { get; set; }
        public Customer Customer { get; set; }
        public IdentityUser IdentityUser { get; set; }
        public Services Services { get; set; }
    }
}
