using AspInlamning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspInlamning.Data
{
    public class DbInitializer
    {
        public static void Initialize(Data.AspInlamningContext context)
        {
            context.Database.EnsureCreated();
            if (context.Attendees.Any() ||
                context.Events.Any() ||
                context.Organizers.Any() ||
                context.Register.Any())
            {

                return;
            }

            Attendee[] attendees = new Attendee[] {
            new Attendee{Name="Test", EmailAdress="Testing", Phone="testa" }
            };
            context.AddRange(attendees);
            context.SaveChanges();

            Organizer[] organizers = new Organizer[] {
            new Organizer{Name="Test", Email="Testar", PhoneNumber="Testing"},
            };
            context.AddRange(organizers);
            context.SaveChanges();

            Event[] events = new Event[] {
            new Event{Title="TestEvent", Organizer=organizers[0], Description="Testar",
                Place="Test", Address="TestAdress", Date="020394", SpotsAvailable=2}


            };
            context.AddRange(events);
            context.SaveChanges();
        }
    }
}
