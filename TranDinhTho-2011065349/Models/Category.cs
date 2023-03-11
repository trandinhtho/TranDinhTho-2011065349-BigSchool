﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TranDinhTho_2011065349.Models
{
    public class Category
    {
        public Byte Id { get; set; }
        [Required]
        [StringLength(255)]
        public String Name { get; set; }
    }
}