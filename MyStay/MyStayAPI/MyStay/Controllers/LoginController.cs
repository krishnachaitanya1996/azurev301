using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyStay.Core.ApplicationServices.IServices;
using MyStay.Core.Entity;

namespace MyStay.Controllers
{
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginServices _loginServices;

        public LoginController(ILoginServices loginServices)
        {
            _loginServices = loginServices;
        }

        [HttpPost]
        [Route("api/Login/PostLogin")]
        public IActionResult PostLogin([FromBody]Login login)
        {
            try
            {
                return Ok(_loginServices.PostLogin(login));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}