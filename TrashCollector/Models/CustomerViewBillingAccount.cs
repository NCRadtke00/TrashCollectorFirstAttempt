﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class CustomerViewBillingAccount
    {
        public Customer customer { get; set; }
        public double customerBill { get; set; }
        //bill needs to have inital trash pick up + recycling fee + latefee

    }
}