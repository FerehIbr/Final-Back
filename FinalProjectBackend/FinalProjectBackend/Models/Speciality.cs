﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectBackend.Models
{
    public class Speciality : BaseEntity
    {
        [StringLength(255), Required]
        public string Name { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
