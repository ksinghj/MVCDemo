﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemo.Models
{
    public class PersonModel
    {
        public  string FirstName { get; set; }
        public  string LastName { get; set; }
        public int Age { get; set; } = 0;
        public bool IsAlive { get; set; } = true;
    }
}
