﻿using System;
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
    }
}