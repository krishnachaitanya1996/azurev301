using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyStayMVC.Models;
using MyStayMVC.Utility;

namespace MyStayMVC.Controllers
{
    public class HotelInfoController : Controller
    {
        public IActionResult HotelDetails()
        {
            HotelInfo hotelInfo = new HotelInfo();
            hotelInfo.lstHotelInfo = GetAllHotelInfo().OrderByDescending(x => x.ID).ToList();

            return View(hotelInfo);
        }

        public IEnumerable<HotelInfo> GetAllHotelInfo()
        {
            return HelperClass.httpGetTAsync<List<HotelInfo>>("api/HotelInfo/GetAllHotelInfo").Result;
        }

        [HttpPost]
        public ActionResult SubmitHotelDetails(HotelInfo hotelInfo)
        {
            int response = HelperClass.httpAzurePostAysnc<HotelInfo>(hotelInfo, "api/AzureHotelInfo").Result;
            ModelState.Clear();
            return RedirectToAction("HotelDetails");
        }

        [HttpPost]
        public ActionResult HotelDetails(HotelInfo hotelInfo)
        {
            IEnumerable<HotelInfo> lstHotelInfo = GetAllHotelInfo();
            ModelState.Clear();
            hotelInfo.lstHotelInfo = lstHotelInfo.Where(x => x.Name.Equals(hotelInfo.Name) || x.Address.Equals(hotelInfo.Address)).ToList();
            return View("HotelDetails", hotelInfo);
        }
    }
}