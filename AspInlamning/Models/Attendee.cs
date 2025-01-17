﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspInlamning.Models
{
    public class Attendee
    {
        public int AttendeeID { get; set; }
        public string Phone { get; set; }
        public string Name { get; set; }
        public string EmailAdress { get; set; }
        public ICollection<Register> Register { get; set; }
    }
}
