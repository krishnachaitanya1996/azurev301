using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyStayMVC.Models;
using MyStayMVC.Utility;

namespace MyStayMVC.Controllers
{
    public class RoomController : Controller
    {
        [Route("Room/RoomDetails")]
        public IActionResult RoomDetails()
        {
            RoomDetails roomDetails = new RoomDetails();
            roomDetails.lstRoomDetails = GetAllRoomDetails().OrderByDescending(x => x.ID).ToList();
            return View(roomDetails);
        }
        [Route("Room/RoomDetails/{id}")]
        public IActionResult RoomDetails(int ID,string HotelName)
        {
            ModelState.Clear();
            RoomDetails roomDetails = new RoomDetails();
            roomDetails.HotelName = HotelName;
            roomDetails.ParentHotelID = ID;
            roomDetails.lstRoomDetails = GetAllRoomDetails().Where(x=>x.ParentHotelID.Equals(ID)).OrderByDescending(x => x.ID).ToList();
            return View("RoomDetails", roomDetails);
        }
        public IActionResult GetRoomDetails(string ID,string HotelName)
        {
            return RedirectToAction("RoomDetails", new { ID = Convert.ToInt32(ID), HotelName = HotelName });
        }
        [HttpPost]
        public ActionResult SubmitRoomDetails(RoomDetails roomDetails)
        {
            int response = HelperClass.httpPostAysnc<RoomDetails>(roomDetails, "api/Room/PostRoomDetails").Result;
            ModelState.Clear();
            return RedirectToAction("RoomDetails", new { ID=roomDetails.ParentHotelID, HotelName=roomDetails.HotelName });
        }

        public List<RoomDetails> GetAllRoomDetails()
        {
            return HelperClass.httpGetTAsync<List<RoomDetails>>("api/Room/GetAllRoomDetails").Result;
        }
    }
}