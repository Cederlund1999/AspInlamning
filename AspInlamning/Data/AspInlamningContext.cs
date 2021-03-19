using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AspInlamning.Models;

namespace AspInlamning.Data
{
    public class AspInlamningContext : DbContext
    {
        public AspInlamningContext (DbContextOptions<AspInlamningContext> options)
            : base(options)
        {
        }

        public DbSet<Attendee> Attendees { get; set; }
        public DbSet<Organizer> Organizers { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Register> Register { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Attendee>().ToTable("Attendee");
            modelBuilder.Entity<Organizer>().ToTable("Organizer");
            modelBuilder.Entity<Event>().ToTable("Event");
            modelBuilder.Entity<Register>().ToTable("Register");
        }
    }
}
