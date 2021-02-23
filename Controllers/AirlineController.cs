using Assignment1B.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1B.Controllers
{
    public class AirlineController : Controller
    {
        public IActionResult Index()
        {
            //Use fake Flight calss/ model to carete and display 10 flights
            //creted an object to hold a list of flights
            var flights = new List<Flight>();
            for(var i = 1; i <10; i++)
            {
                flights.Add(new Flight {Id = i, Name = "Flight" + i.ToString() });
            }
            // modified the return statement so that now it can accept 10 flights to pass to the view and display
            return View(flights);
        }

        public IActionResult Reservation(string flight)
        {
            ViewBag.flight = flight;
            return View();
        }

        // /Srore/Airline
        public IActionResult AddFlight()
        {
            //load a form to capture an object from the user
            return View();
        }
    }
}
