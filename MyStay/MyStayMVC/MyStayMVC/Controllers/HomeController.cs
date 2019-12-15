using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using MyStayMVC.Models;

namespace MyStayMVC.Controllers
{
    public class HomeController : Controller
    {
        private IDistributedCache _cache;

        public HomeController(IDistributedCache cache)
        {
            _cache = cache;
        }

        public IActionResult Index()
        {
            string value = _cache.GetString("CacheTime");

            if(value==null)
            {
                value = DateTime.Now.ToString();
                var options = new DistributedCacheEntryOptions();
                options.SetSlidingExpiration(TimeSpan.FromMinutes(1));
                _cache.SetString("CacheTime", value, options);
            }

            ViewData["CacheTime"] = value;
            ViewData["CurrentTime"] = DateTime.Now.ToString();

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
