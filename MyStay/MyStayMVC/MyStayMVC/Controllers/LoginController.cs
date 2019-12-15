using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyStayMVC.Models;
using MyStayMVC.Utility;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace MyStayMVC.Controllers
{

    public class LoginController : Controller
    {

        public ActionResult Login()
        {
            return View();
        }
        public IActionResult LoginFacebook(string provider, string returnUrl = null)
        {
            return Challenge(new AuthenticationProperties { RedirectUri = Url.Action("HotelDetails", "HotelInfo") }, provider);
        }

        //[Route("Login/{provider}")]
        //public IActionResult LoginTest(string provider, string returnUrl = null)
        //{
        //    //HttpContext.Session.SetString("UserName", User.Identity.Name);
        //    //HttpContext.Session.SetString("UserRole", User.Identity.Name);

        //    return Challenge(new AuthenticationProperties { RedirectUri = returnUrl ?? "/" }, provider);

        //}

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(RegisteredUsers registeredUsers)
        {
            int result = HelperClass.httpPostAysnc<RegisteredUsers>(registeredUsers, "RegisteredUsers/PostRegisteredUsersDetails").Result;
            if (result > 0)
            {
                return RedirectToAction("Login");
            }
            else
            {
                ViewBag.Message = "Something went wrong. Please contact Administrator";
                return View();
            }
        }
        [HttpPost]
        public ActionResult Login(Login login)
        {
            List<RegisteredUsers> lstRegisteredUsers = new List<RegisteredUsers>();
            if (ModelState.IsValid)
            {
                lstRegisteredUsers = HelperClass.httpGetTAsync<List<RegisteredUsers>>("api/RegisteredUsers/GetAllRegisteredUsersDetails").Result;
                lstRegisteredUsers = lstRegisteredUsers.AsEnumerable().Where(x => x.Email.Equals(login.UserName) && x.Password.Equals(login.Password)).ToList();
                if (lstRegisteredUsers.Count == 0)
                {
                    ViewBag.Message = "Register to login";
                    return View();
                }
                else
                {
                    HttpContext.Session.SetString("UserName", lstRegisteredUsers[0].FullName);
                    HttpContext.Session.SetString("UserRole", lstRegisteredUsers[0].IsAdmin ? Constants.UserRole_Admin : Constants.UserRole_User);


                    if (lstRegisteredUsers[0].IsAdmin)
                        return RedirectToAction("HotelDetails", "HotelInfo");
                    else
                        return RedirectToAction("BookingDetails", "Booking");
                }
            }
            return View();
        }

        public ActionResult LogOut()
        {
            foreach (var key in this.HttpContext.Request.Cookies.Keys)
            {
                this.HttpContext.Response.Cookies.Delete(key);
            }

            return RedirectToAction("Login", "Login");
        }

    }
    public static class SessionExtensions
    {
        public static void Set<T>(this ISession session, string key, T value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static T Get<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }
    }
}