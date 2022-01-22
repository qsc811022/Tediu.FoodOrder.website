﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tediu.FoodOrder.website.Models.EFModel
{
    public class FoodTableModel
    {
        public int id { get; set; }

        [DisplayName("品項")]
        [Required]
        public string FoodName { get; set; }

        [DisplayName("價格")]
        [Required]
        public int FoodPrice { get;set;}

        [DisplayName("部門")]
        [Required]
        public string dep { get;set;}

        [DisplayName("姓名")]
        [Required]
        public string Name { get;set;}

    }
}
