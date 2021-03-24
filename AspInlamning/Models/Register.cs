using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspInlamning.Models
{
    public class Register
    {
        public int RegisterID { get; set; }
        public Attendee Attendee { get; set; }
        public Event Event { get; set; }
    }
}
