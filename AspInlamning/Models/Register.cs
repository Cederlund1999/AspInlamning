using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspInlamning.Models
{
    public class Register
    {
        public int RegEventsID { get; set; }
        public int AttendeeID { get; set; }
        public int EventID { get; set; }

        public Attendee Attendee { get; set; }
        public Event Event { get; set; }
    }
}
