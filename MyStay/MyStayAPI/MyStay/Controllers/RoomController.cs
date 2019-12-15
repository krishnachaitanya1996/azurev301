using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyStay.Core.ApplicationServices.IServices;
using MyStay.Core.Entity;

namespace MyStayAPI.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomServices _RoomServices;

        public RoomController(IRoomServices RoomServices)
        {
            _RoomServices = RoomServices;
        }

        [HttpPost]
        [Route("api/[controller]/PostRoomDetails")]
        public IActionResult PostRoomDetails([FromBody]RoomDetails roomDetails)
        {
            try
            {
                return Ok(_RoomServices.PostRoomDetails(roomDetails));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("api/[controller]/GetAllRoomDetails")]
        public IEnumerable<RoomDetails> GetAllRoomDetails()
        {
            return _RoomServices.GetAllRoomDetails();
        }
    }
}