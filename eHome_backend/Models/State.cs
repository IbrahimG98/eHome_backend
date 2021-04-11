﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eHome_backend.Models
{
    public class State
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int? CountryID { get; set; }
        public Country Country { get; set; }
    }
}
