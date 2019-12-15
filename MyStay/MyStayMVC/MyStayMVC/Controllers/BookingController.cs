using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyStayMVC.Models;
using MyStayMVC.Utility;

namespace MyStayMVC.Controllers
{
    public class BookingController : Controller
    {
        public IActionResult BookingDetails()
        {
            Booking booking = new Booking();
            booking.lstBooking = GetAllBookingDetails();
            GetDropDownList();
            return View(booking);
        }

        public IActionResult AddBooking()
        {
            GetDropDownList();
           return View();
        }

        private void GetDropDownList()
        {
            ViewBag.lstHotelInfo = new SelectList(new HotelInfoController().GetAllHotelInfo().ToList(),"ID","Name");
            ViewBag.lstRooms = new SelectList(new RoomController().GetAllRoomDetails().ToList().ToList(), "ID", "RoomNumber");
        }

        [HttpPost]
        public ActionResult SubmitBookingDetails(Booking booking)
        {
            int response = HelperClass.httpPostAysnc<Booking>(booking, "api/Booking/PostBookingDetails").Result;
            ModelState.Clear();
            return RedirectToAction("BookingDetails");
        }
        public List<Booking> GetAllBookingDetails()
        {
            return HelperClass.httpGetTAsync<List<Booking>>("api/Booking/GetAllBookingDetails").Result;
        }
        [HttpPost]
        public ActionResult BookingDetails(Booking booking)
        {
            List<Booking> lstbooking = GetAllBookingDetails();
            
            booking.lstBooking = lstbooking.Where(x => x.ParentHotelID.Equals(booking.ParentHotelID) ||
                                             x.ParentRoomID.Equals(booking.ParentRoomID) ||
                                             (x.StartDate >= booking.StartDate && x.EndDate <= (booking.EndDate==null?DateTime.Now.Date:booking.EndDate))).ToList();
            GetDropDownList();
            return View("BookingDetails", booking);
        }

    }
}