﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherApp.Models
{
    public class City
    {
        [Key]
        public string Key { get; set; }

        public string LocalizedName { get; set; }
    }
}