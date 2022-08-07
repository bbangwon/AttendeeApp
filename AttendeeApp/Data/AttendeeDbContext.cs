using AttendeeApp.Models;
using Microsoft.EntityFrameworkCore;

namespace AttendeeApp.Data
{
    public class AttendeeDbContext : DbContext
    {
        public AttendeeDbContext(DbContextOptions<AttendeeDbContext> options) : base(options)
        {

        }

        public DbSet<Attendee>? Attendees { get; set; }
    }
}

