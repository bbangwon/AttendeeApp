using System;
using AttendeeApp.Models;

namespace AttendeeApp.Services
{
    public interface IAttendeeRepository
    {
        List<Attendee> GetAttendees();
        void Add(Attendee attendee);
        
    }
}

