using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyStayMVC.Models;
using MyStayMVC.Utility;

namespace MyStayMVC.Controllers
{
    public class PaymentController : Controller
    {
        public IActionResult PaymentDetails(int ID)
        {
            int response = HelperClass.httpPostAysnc<Payment>(new Payment { ParentBookingID = ID,PaymentStatus=Constants.PaymentStatus_Paid }, "api/Payment/PostPaymentDetails").Result;

            return Json(new { returnvalue = response });
            //return RedirectToAction("BookingDetails", "Booking");
        }
    }
}