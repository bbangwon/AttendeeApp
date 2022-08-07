using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AttendeeApp.Models;
using AttendeeApp.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AttendeeApp.Controllers
{
    public class AttendeeController : Controller
    {
        private readonly IAttendeeRepository attendeeRepository;

        public AttendeeController(IAttendeeRepository attendeeRepository)
        {
            this.attendeeRepository = attendeeRepository;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var attendees = attendeeRepository.GetAttendees();
            return View(attendees);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Attendee model)
        {
   
            if(ModelState.IsValid)
            {
                this.attendeeRepository.Add(model);
                return RedirectToAction("Index");
            }

            return View(model);
        }
    }
}

