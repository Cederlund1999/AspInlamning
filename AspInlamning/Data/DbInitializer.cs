﻿using AspInlamning.Models;
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
            if (context.Events.Any())
            {

                return;
            }

            Attendee[] attendees = new Attendee[] {
            new Attendee{Name="Gustav", EmailAdress="Gustavtest@gmail.com", Phone="0768156023" }
            };
            context.AddRange(attendees);
            context.SaveChanges();

            Organizer[] organizers = new Organizer[] {
            new Organizer{Name="Middagsplaneraren", Email="Middagsplaneraren@gmail.com", PhoneNumber="0758259344"},
            new Organizer{Name="SFBio", Email="SFAnytime@gmail.com", PhoneNumber="0762839212"}
            };
            context.AddRange(organizers);
            context.SaveChanges();

            Event[] events = new Event[] {
            new Event{Title="Middag", Organizer=organizers[0], Description="En middag på en restaurang i GBG. God mat och dryck!",
                Place="O'Learys", Address="Kungsportsavenyen 9", Date=DateTime.Now.AddDays(1), SpotsAvailable=12},
            new Event{Title="Bio", Organizer=organizers[1], Description="Film",
                Place="Göteborg", Address="Skånegatan 16 B", Date=DateTime.Now.AddDays(4), SpotsAvailable=14}



            };
            context.AddRange(events);
            context.SaveChanges();
        }
    }
}
