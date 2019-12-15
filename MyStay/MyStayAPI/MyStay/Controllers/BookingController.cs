using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyStay.Core.Entity;
using MyStay.Core.ApplicationServices.IServices;
using MyStayAPI.AzureServices;

namespace MyStayAPI.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingServices _BookingServices;

        public BookingController(IBookingServices BookingServices)
        {
            _BookingServices = BookingServices;
        }

        [HttpPost]
        [Route("api/[controller]/PostBookingDetails")]
        public IActionResult PostBookingDetails([FromBody]Booking bookingDetails)
        {
            try
            {
                EventHubPost.PostToEventHub(bookingDetails).GetAwaiter().GetResult();

                return Ok(_BookingServices.PostBookingDetails(bookingDetails));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("api/[controller]/GetAllBookingDetails")]
        public IEnumerable<Booking> GetAllBookingDetails()
        {
            return _BookingServices.GetAllBookingDetails();
        }
    }
}