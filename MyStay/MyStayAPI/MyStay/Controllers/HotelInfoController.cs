using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.ApplicationInsights;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyStay.Core.ApplicationServices.IServices;
using MyStay.Core.ApplicationServices.Services;
using MyStay.Core.Entity;

namespace MyStay.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class HotelInfoController : ControllerBase
    {
        private readonly IHotelInfoServices _hotelInfoServices;

        public HotelInfoController(IHotelInfoServices hotelInfoServices)
        {
            _hotelInfoServices = hotelInfoServices;
        }

        [HttpGet]
        [Route("api/[controller]/GetAllHotelInfo")]
        public IEnumerable<HotelInfo> GetAllHotelInfo()
        {
            var telemetry = new TelemetryClient();
            for (int i = 0; i < 30; i++)
            {
                int p = 0;
                try
                {
                    var test = 100/p;
                }
                catch (Exception ex)
                {

                    // Send the exception telemetry:
                    telemetry.TrackException(ex);
                }
            }
            return _hotelInfoServices.GetAllHotelInfo();
        }

        [HttpPost]
        [Route("api/[controller]/PostHotelDetails")]
        public IActionResult PostHotelDetails([FromBody]HotelInfo hotelInfo)
        {
            try
            {
                return Ok(_hotelInfoServices.PostHotelDetails(hotelInfo));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}