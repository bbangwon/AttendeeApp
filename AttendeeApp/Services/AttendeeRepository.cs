using AttendeeApp.Data;
using AttendeeApp.Models;

namespace AttendeeApp.Services
{
    public class AttendeeRepository : IAttendeeRepository
    {
        private readonly AttendeeDbContext attendeeDbContext;

        public AttendeeRepository(AttendeeDbContext attendeeDbContext)
        {
            this.attendeeDbContext = attendeeDbContext;
        }

        public void Add(Attendee attendee)
        {
            attendeeDbContext.Attendees?.Add(attendee);
            attendeeDbContext.SaveChanges();
        }

        public List<Attendee> GetAttendees()
        {
            return attendeeDbContext.Attendees?.ToList() ?? new List<Attendee>();
        }
    }
}

